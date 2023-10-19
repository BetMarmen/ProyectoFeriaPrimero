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
    public partial class EstadoResultado : Form
    {
        public EstadoResultado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void setCT(double ct)
        {
            txtComprasTotales.Text = ct.ToString();
        }
        public void setVentasTotales(double ventasTotales) 
        {
            txtVentasTotales.Text= ventasTotales.ToString();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtVentasTotales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (txtVentasTotales.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComprasTotales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5;  

            if (txtComprasTotales.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuDsV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (nuDsV.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuDsVtas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (nuDsVtas.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nugastoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (nugastoCompra.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuDSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (nuDSC.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuDesSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; // Cambia este valor al número máximo de cifras permitidas

            if (nuDesSC.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuRebajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 
            if (nuRebajas.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuInvI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (nuInvI.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuInvF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (nuInvF.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 
            if (nuGastosVentas.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 
            if (nuGastosAdmo.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; 

            if (nuGastosFinancieros.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén los valores ingresados por el usuario desde los TextBox
                double ventasTotales = double.Parse(txtVentasTotales.Text);
                double devolucionesVentas = double.Parse(nuDsVtas.Text);
                double descuentosVentas = double.Parse(nuDsV.Text);
                double comprasTotales = double.Parse(txtComprasTotales.Text);
                double devolucionesCompras = double.Parse(nuDSC.Text);
                double descuentosCompras = double.Parse(nuDesSC.Text);
                double rebajasCompras = double.Parse(nuRebajas.Text);
                double gastoCompras = double.Parse(nugastoCompra.Text);
                double inventarioInicial = double.Parse(nuInvI.Text);
                double inventarioFinal = double.Parse(nuInvF.Text);
                double gastosVentas = double.Parse(nuGastosVentas.Text);
                double gastosAdministrativos = double.Parse(nuGastosAdmo.Text);
                double gastosFinancieros = double.Parse(nuGastosFinancieros.Text);

                // Calcula las categorías según las columnas
                double comprasYGastosCompras = comprasTotales + gastoCompras;
                double descuentosYDevoluciones = descuentosVentas + devolucionesVentas + descuentosCompras + devolucionesCompras + rebajasCompras;
                double ventasEInventario = ventasTotales + inventarioInicial - (comprasTotales - descuentosYDevoluciones) - inventarioFinal;
                double utilidades = ventasTotales - descuentosYDevoluciones - comprasYGastosCompras - gastosVentas - gastosAdministrativos - gastosFinancieros;

                // Limpia el DataGridView antes de agregar nuevos datos
                dataEstadoR.Rows.Clear();

                // Agrega los valores calculados al DataGridView
                dataEstadoR.Rows.Add("Compras y Gastos de Compras", comprasYGastosCompras, "", "", "");
                dataEstadoR.Rows.Add("Descuentos y Devoluciones", "", descuentosYDevoluciones, "", "");
                dataEstadoR.Rows.Add("Ventas e Inventario", "", "", ventasEInventario, "");
                dataEstadoR.Rows.Add("Utilidades", "", "", "", utilidades);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en los campos.");
            }
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormato.SelectedItem=="EXCEL") Formato.ExportToExcel(dataEstadoR);
            if (cboFormato.SelectedItem=="PDF") Formato.ExportToPDF(dataEstadoR);
            if (cboFormato.SelectedItem=="WORD") Formato.ExportToDocX(dataEstadoR);
            if (cboFormato.SelectedItem=="TXT") Formato.ExportToText(dataEstadoR);
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
            MenuOpciones menuOpciones = new MenuOpciones();
            this.Hide();
            menuOpciones.ShowDialog();
        }
    }
}
