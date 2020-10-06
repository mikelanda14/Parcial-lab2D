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
using FrmLogin;

namespace FrmLogin
{
    public partial class FrmAbmProducto : Form
    {
        public FrmAbmProducto()
        {
            InitializeComponent();
            this.cbCategoria.DataSource = Enum.GetValues(typeof(Producto.Categoria));
            //yourComboBox.DataSource = Enum.GetValues(typeof(YourEnum));
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            AgregarProductoInventario(sender, e);
        }

        private void AgregarProductoInventario(object sender, EventArgs e)
        {
            int codigo;
            float precio;
            int unidades;
            if (txtCodigoProducto.Text != string.Empty && txtNombreProducto.Text != string.Empty)
            {
                int.TryParse(txtUnidades.Text, out unidades);
                int.TryParse(txtCodigoProducto.Text, out codigo);
                float.TryParse(txtPrecioProducto.Text, out precio);
                Mart.AgregarProductoCategoria(codigo, txtMarcaProducto.Text, txtNombreProducto.Text, precio, unidades,cbCategoria.Text.ToString());
               // Invetario.Add(new Producto(codigo, txtMarcaProducto.Text.ToString(), txtNombreProducto.Text.ToString(), precio, unidades));
                this.Close();
            }
            else
            {
                MessageBox.Show("Es nesesario Completar todos los  campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAbmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
