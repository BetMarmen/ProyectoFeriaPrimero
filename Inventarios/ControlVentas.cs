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
    public partial class ControlVentas : Form
    {
        public ControlVentas()
        {
            InitializeComponent();
        }

        private void btnregistar_Click(object sender, EventArgs e)
        {
            dataVentas.Rows.Add(txtProducto.Text, nuPrecio.Value, nuCantidad.Value, nuPrecio.Value*nuCantidad.Value);
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormato.SelectedItem=="EXCEL") Formato.ExportToExcel(dataVentas);
            if (cboFormato.SelectedItem=="PDF") Formato.ExportToPDF(dataVentas);
            if (cboFormato.SelectedItem=="WORD") Formato.ExportToDocX(dataVentas);
            if (cboFormato.SelectedItem=="TXT") Formato.ExportToText(dataVentas);
        }

        private void dataVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        double contador;
        public double getContador()
        { return contador; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            contador=0.0;
            foreach (DataGridViewRow row in dataVentas.Rows)
            {
                decimal valorfila = 0;
                if (row.Cells[1].Value != null)
                {
                    decimal valorFila = 0;
                    if (decimal.TryParse(row.Cells[3].Value.ToString(), out valorFila))
                    {
                        contador += (double)(valorFila);
                    }
                }

            }
            txtVentasT.Text=contador.ToString();

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void nuPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; // Cambia este valor al número máximo de cifras permitidas

            if (nuPrecio.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nuCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            int maxLength = 5; // Cambia este valor al número máximo de cifras permitidas

            if (nuCantidad.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVentasT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataVentas.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dataVentas.SelectedRows[0];

                // Elimina la fila del DataGridView
                dataVentas.Rows.Remove(filaSeleccionada);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuOpciones menuOpciones = new MenuOpciones();
            this.Hide();
            menuOpciones.ShowDialog();
        }
    }
}
