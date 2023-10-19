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
            try
            {
                EstadoResultado estadoResultado = new EstadoResultado();
       
                if (controlVentas!=null)
                {
                    if (inventario!=null)
                    {
                        estadoResultado.setVentasTotales(controlVentas.getContador());
                        estadoResultado.setCT(inventario.getContador());
                       
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
