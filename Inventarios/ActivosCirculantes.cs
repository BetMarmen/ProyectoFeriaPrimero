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
    public partial class ActivosCirculantes : Form
    {
        public ActivosCirculantes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private List<Cuenta> listaCuentas = new List<Cuenta>();
        
        public List<Cuenta> ListaCuenta()
        {
            return new List<Cuenta>(listaCuentas);
        }
        public void setData(DataGridView dgv)
        {
            dataCuentasActivos= dgv;
        }
        public DataGridView getData()
        {
            btnGuardar.PerformClick();
            return dataCuentasActivos;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "") dataCuentasActivos.Rows.Add(txtNombre.Text, nuMonto.Value);
            else MessageBox.Show("Por favor ingrese una cuenta");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataCuentasActivos.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dataCuentasActivos.SelectedRows[0];

                // Elimina la fila del DataGridView
                dataCuentasActivos.Rows.Remove(filaSeleccionada);
            }

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            listaCuentas = null;
            listaCuentas = new List<Cuenta>();
            
            // Supongamos que tienes un DataGridView llamado dataGridView1
            txtTotal.Text = "0"; // Inicializa el TextBox a "0"

            for (int i = 0; i < dataCuentasActivos.Rows.Count - 1; i++)
            {
                DataGridViewRow fila = dataCuentasActivos.Rows[i];

                // Accede al valor de la celda
                string nombreCuenta = fila.Cells[0].Value != null ? fila.Cells[0].Value.ToString() : string.Empty;

                if (double.TryParse(fila.Cells[1].Value != null ? fila.Cells[1].Value.ToString() : "0", out double monto))
                {
                    listaCuentas.Add(new Cuenta(nombreCuenta, monto));
                    txtTotal.Text = (double.Parse(txtTotal.Text) + monto).ToString();
                }
                else
                {
                    // Manejar un error en la conversión
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; // Cambia este valor al número máximo de cifras permitidas

            if (txtTotal.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
