using ResultaFacil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class RegistroInventario : Form
    {
       
        public RegistroInventario()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnregistar_Click(object sender, EventArgs e)
        {
            string productoNuevo = txtProducto.Text;
            double precioNuevo = (double)nuPrecio.Value;
            int cantidadNuevo = (int)nuCantidad.Value;

            bool productoEncontrado = false;

            foreach (DataGridViewRow row in dataInventario.Rows)
            {
                string productoExistente = row.Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(productoExistente) && productoExistente == productoNuevo)
                {
                    double? precioExistente = row.Cells[1].Value as double?;
                    int? cantidadExistente = row.Cells[2].Value as int?;

                    if (precioExistente != null && cantidadExistente != null)
                    {
                        // Calcular la media de los precios
                        double media = ((double)precioExistente  + precioNuevo ) / 2;

                        // Actualizar los valores existentes en la fila
                        row.Cells[1].Value = media;
                        row.Cells[2].Value = (int)cantidadExistente + cantidadNuevo;
                        row.Cells[3].Value=media*((int)cantidadExistente + cantidadNuevo);
                        productoEncontrado = true;
                        break;
                    }
                }
            }

            if (!productoEncontrado)
            {
                // Si el producto no existe, agregar una nueva fila
                dataInventario.Rows.Add(productoNuevo, precioNuevo, cantidadNuevo,precioNuevo*cantidadNuevo);
            }
            txtProducto.Clear();
            
        }

        private void cboFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormato.SelectedItem=="EXCEL") Formato.ExportToExcel(dataInventario);
            if (cboFormato.SelectedItem=="PDF") Formato.ExportToPDF(dataInventario);
            if (cboFormato.SelectedItem=="WORD") Formato.ExportToDocX(dataInventario);
            if (cboFormato.SelectedItem=="TXT") Formato.ExportToText(dataInventario);
        }

        private void RegistroInventario_Load(object sender, EventArgs e)
        {

        }
        double contador1;
        public double getContador()
        { return contador1; }
        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("server=GoGui\\GOGUI; database=Feria ; integrated security = true; user=sa; password=123456");
            //conexion.Open();
            //MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            //conexion.Close();
            //MessageBox.Show("Se cerró la conexión.");
            // abrimos conexion
            conexion.Open();

            contador1 =0.0;
            foreach (DataGridViewRow row in dataInventario.Rows)
            {
                double? precioExistente = row.Cells[3].Value as double?;
                if (precioExistente != null)
                {
                    contador1 += (double)(precioExistente);
                }
            }
            txtComprasT.Text=contador1.ToString();

            string cadena = "insert into Compras(TotalCompras) values (" + contador1 + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            // cerramos conexion
            conexion.Close();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComprasT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
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
            int maxLength = 5; 

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
            int maxLength = 5; 

            if (nuCantidad.Text.Length >= maxLength && !char.IsControl(e.KeyChar))
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuOpciones menuOpciones = new MenuOpciones();
            this.Hide();
            menuOpciones.ShowDialog();
            
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataInventario.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dataInventario.SelectedRows[0];

                // Elimina la fila del DataGridView
                dataInventario.Rows.Remove(filaSeleccionada);
            }
        }
    }
}
