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
    public partial class MenuOpciones : Form
    {
        public MenuOpciones()
        {
            InitializeComponent();
        }
        RegistroInventario inventario;
        ControlVentas controlVentas;
        private void btnInventario_Click(object sender, EventArgs e)
        {
            inventario= new RegistroInventario();
            
            //this.Hide();
            inventario.ShowDialog();
            
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            CuentasBalance cuentasBalance = new CuentasBalance();
            this.Hide();
            cuentasBalance.ShowDialog();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            controlVentas = new ControlVentas();
            //this.Hide();
            controlVentas.ShowDialog();
            //this.Close();
        }

        private void btnER_Click(object sender, EventArgs e)
        {

                SqlConnection conexion = new SqlConnection("server=GoGui\\GOGUI; database=Feria ; integrated security = true; user=sa; password=123456");
            try
            {
                conexion.Open();

                EstadoResultado estadoResultado = new EstadoResultado();
                double compras = 0;
                double ventas = 0;

                string cadena = "select sum(TotalCompras) as total from Compras";
                string cventa = "select sum(TotalVentas) as total from Ventas";
                SqlCommand comando = new SqlCommand(cadena, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    // Aquí puedes acceder a los datos del registro
                    compras = Convert.ToDouble(reader["total"]);
                    // ... y así sucesivamente

                    // Cierra el lector cuando hayas terminado de usarlo
                    reader.Close();
                }

                comando = new SqlCommand(cventa, conexion);

                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    // Aquí puedes acceder a los datos del registro
                    ventas = Convert.ToDouble(reader["total"]);
                    // ... y así sucesivamente

                    // Cierra el lector cuando hayas terminado de usarlo
                    reader.Close();
                }

                if (ventas!=null)
                {
                    if (compras!=null)
                    {

                        estadoResultado.setVentasTotales(ventas);
                        estadoResultado.setCT(compras);
                       
                        estadoResultado.Show();
                    }
                    else { MessageBox.Show("No existe nada en compras"); }
                    
                }
                else { MessageBox.Show("No existe nada en ventas"); }
            }
            catch (Exception)
            {

                MessageBox.Show("Tiene que registrar las compras y ventas");
            }
            finally {
                
                // cerramos conexion
                conexion.Close();
            }
            
            /*this.Hide();
            estadoResultado.ShowDialog();
            this.Close();
            */
        }

        private void btnControlInventario_Click(object sender, EventArgs e)
        {
            frmInventarios frmInventarios = new frmInventarios();
            this.Hide();
            frmInventarios.ShowDialog();
            this.Close();   
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
