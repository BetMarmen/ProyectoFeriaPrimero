using ResultaFacil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class CuentasBalance : Form
    {
        public CuentasBalance()
        {
            InitializeComponent();
        }
        ActivosCirculantes[] arrayDeFormulario = new ActivosCirculantes[6];
        string[] encabezado = { "Activos Circulantes", "Activos Fijos", "Activos Diferidos", "Disminuciones", "Pasivos Circulantes", "Pasivos no Circulantes" };
        private void CuentasBalance_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayDeFormulario.Length; i++)
            {
                arrayDeFormulario[i] = new ActivosCirculantes();
                arrayDeFormulario[i].label1.Text = encabezado[i];
               // arrayAUX[i]=arrayDeFormulario[i];
            }
        }
        
        private void btnAC_Click(object sender, EventArgs e)
        {
            arrayDeFormulario[0]=new ActivosCirculantes();
            arrayDeFormulario[0].label1.Text=encabezado[0];
            //arrayDeFormulario[0]=arrayAUX[0];
            arrayDeFormulario[0].Show();

        }
        private List<Cuenta> listaCuentas = null;
       

        private void CuentasBalance_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayDeFormulario.Length; i++)
            {
                arrayDeFormulario[i] = new ActivosCirculantes();
                arrayDeFormulario[i].label1.Text = encabezado[i];
            }
        }

        private void btnMostrarBalance_Click_1(object sender, EventArgs e)
        {
           
            listaCuentas = null;
            listaCuentas = new List<Cuenta>();
            double suma_cuenta = 0.0, suma_activo = 0.0, suma_pasivo = 0.0;

            for (int i = 0; i < arrayDeFormulario.Length; i++)
            {
                suma_cuenta = 0.0;

                if (arrayDeFormulario[i] != null) // Verifica si el formulario no es nulo
                {
                    foreach (Cuenta pivote in arrayDeFormulario[i].ListaCuenta())
                    {
                        listaCuentas.Add(pivote);
                        suma_cuenta += pivote.Monto;
                    }
                }
                listaCuentas.Add(new Cuenta(encabezado[i] + " Totales", suma_cuenta));

                if (i < 3)
                {
                    suma_activo += suma_cuenta;
                }
                else
                {
                    suma_activo -= suma_cuenta;
                }
            }

            suma_pasivo = suma_activo - suma_pasivo;

            listaCuentas.Add(new Cuenta("Capital", suma_pasivo));
            dataBalance.Columns.Clear();
            this.dataBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            foreach (Cuenta pivote in listaCuentas)
            {
                dataBalance.Rows.Add(pivote.NombreCuenta, pivote.Monto);
            }

        }

        private void btnAF_Click(object sender, EventArgs e)
        {
            arrayDeFormulario[1].Show();
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            arrayDeFormulario[2].Show();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            arrayDeFormulario[4].Show();
        }

        private void btnPNC_Click(object sender, EventArgs e)
        {
            arrayDeFormulario[5].Show();
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormato.SelectedItem=="EXCEL") Formato.ExportToExcel(dataBalance);
            if (cboFormato.SelectedItem=="PDF") Formato.ExportToPDF(dataBalance);
            if (cboFormato.SelectedItem=="WORD") Formato.ExportToDocX(dataBalance);
            if (cboFormato.SelectedItem=="TXT") Formato.ExportToText(dataBalance);
        }

        private void btnDisminuciones_Click(object sender, EventArgs e)
        {
            arrayDeFormulario[3].Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuOpciones menuOpciones=new MenuOpciones();
            this.Hide();
            menuOpciones.ShowDialog();
        }
    }
}
