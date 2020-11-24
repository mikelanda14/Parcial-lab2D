using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;



namespace FPrincipal
{
    /// <summary>
    /// Declaracion del Delegato
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public delegate void GenerarTicket(string a , string b);


  
    public partial class FrmPrincial : Form
    {

        public event GenerarTicket Inprimir;

        
        public FrmPrincial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant();
            this.CargadeMenu();
            FrmColaPedidos frmColaPedidos = new FrmColaPedidos();
            frmColaPedidos.Show();
            Restaurant.PreCargadoPedidos();
            Restaurant.NumeroPedido = Restaurant.viewPedidos().Count;
        }

        private void CargadeMenu()
        {

            DB.GetMenu();

            DgProductos.RowHeadersVisible = false;
            DgProductos.DataSource = null;
            DgProductos.DataSource = Restaurant.viewMenu();
           
        }

       
        private void Venta(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Restaurant.AgregarVenta(int.Parse(DgProductos.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString()), DgProductos.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString(), float.Parse(DgProductos.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString()));
                DgVenta.RowHeadersVisible = false;
                DgVenta.DataSource = null;
                DgVenta.DataSource = Restaurant.viewVentas();
                Calculo();
            }
            catch (Exception )
            {
              
               
            }
            
                
            
            
        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Venta(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarRespaldoPedido();
        }

        private void GenerarPedido()
        {
            Restaurant.AgregarPedido(Restaurant.CalculoImportePedido(),Restaurant.DescripcionPedido(),txtNombre.Text.ToString(),Restaurant.NumeroPedido++,this.checkBox1.Checked);
           
            
            Restaurant.LimpiarVentas();
            DgVenta.DataSource = null;


        }
       

        private void Calculo()
        {
            this.lblTotal.Text = Restaurant.CalculoImportePedido().ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                richTextBox1.Enabled = true;
            }
            else
            {
                richTextBox1.Enabled = false;
            }
        }

        private void GenerarRespaldoPedido()
        {
            Restaurant restaurant = new Restaurant();
            if (txtNombre.Text != string.Empty && float.Parse(lblTotal.Text.ToString()) != 0)
            {
                if (checkBox1.Checked && richTextBox1.Text != string.Empty || checkBox1.Checked == false && richTextBox1.Text == string.Empty)
                {
                    if (checkBox1.Checked && richTextBox1.Text != string.Empty)
                    {
                        Inprimir += Restaurant.Guardar;
                        Inprimir.Invoke(txtNombre.Text.ToString(), richTextBox1.Text.ToString());
                    }
                    DB.InsertPedido(Restaurant.DescripcionPedido(), ExtensionRestaurant.ExtensionCalculoImporte(restaurant));

                    GenerarPedido();
                    lblTotal.Text = "0";
                    txtNombre.Text = "";
                    checkBox1.Checked = false;
                    richTextBox1.Text = "";
                }
            }
        }
        
    }
}
