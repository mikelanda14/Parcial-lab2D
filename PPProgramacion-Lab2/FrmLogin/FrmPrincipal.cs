using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;
namespace FrmLogin
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal(string usuario)
        {
            InitializeComponent();
            this.label1.Text = usuario;

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            RecargarInventario();
            Compras.LimpiarLista();

        }

        private void mostrarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RecargarInventario();


        }
        private void RecargarInventario()
        {
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);


            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Invetario.View();

            dataGridView3.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);


        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmProducto frmAbmProducto = new FrmAbmProducto();
            frmAbmProducto.ShowDialog();
            this.RecargarInventario();


        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            agregarArticulo(sender, e);




        }

        private void agregarArticulo(object sender, DataGridViewCellMouseEventArgs e)
        {
            int codigo = int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString());
            string marca = dataGridView3.Rows[e.RowIndex].Cells["Marca"].FormattedValue.ToString();
            string nombre = dataGridView3.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
            float precio = float.Parse(dataGridView3.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString());


            if (Validaciones.ValidarCliente(textBox1.Text.ToString()) == "Cliente no registrado" || textBox1.Text.ToString() == "")
            {
                MessageBox.Show("Cliente no registrado Ingresar DNI en la casilla o registre el cliente.");
            }
            else
            {
                label2.Text = Validaciones.ValidarCliente(textBox1.Text.ToString());
                if (e.RowIndex >= 0)
                {
                    if (Invetario.GetUnidades(int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString())) > 0 && Compras.GetUnidades(int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString())) < Invetario.GetUnidades(int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString())))
                    {
                        if (Compras.Existe(int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString())))
                        {

                            Compras.ModificacionLista(int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString()));
                        }
                        else
                        {

                            Mart.AgregarProductoCategoriaCompras(codigo, marca, nombre , precio, 1,dataGridView3.Rows[e.RowIndex].Cells["CategoriaP"].FormattedValue.ToString());
                           // Compras.Add(new Producto(int.Parse(dataGridView3.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString()), dataGridView3.Rows[e.RowIndex].Cells["Marca"].FormattedValue.ToString(), dataGridView3.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString(), float.Parse(dataGridView3.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString()), 1));

                        }
                        this.Caltulo();

                    }
                    else
                    {
                        MessageBox.Show("Sin stock");
                    }
                }
            }

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Compras.LimpiarLista();
            dataGridView1.DataSource = null;
            lblTotal.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Producto item in Compras.View())
            {

                Invetario.ModificacionLista(item.Codigo, (item.Unidades) * -1);
            }


            if (Validaciones.ValidarEmpleado(this.textBox1.Text.ToString()))
            {
                for (int i = 0; i < Mart.View().Count; i++)
                {
                    if (Mart.View()[i].GetDni == int.Parse(this.textBox1.Text.ToString()))
                    {
                        Mart.View()[i].Setventa(Compras.mostar());
                    }
                }
            }
            Compras.LimpiarLista();
            dataGridView1.DataSource = null;

            
            label2.Text = "";
            this.RecargarInventario();
            if (textBox1.Text != string.Empty && lblTotal.Text != "Gracias por su comprass")
            {
                lblTotal.Text = "Gracias por su comprass";
                SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\miguel.landaeta\Downloads\Cash Register Cha Ching-SoundBible.com-184076484.wav");
                soundPlayer.Play();
            }


        }

        private void RepoteStock(object sender, EventArgs e)
        {
            foreach (Producto item in Invetario.View())
            {
                if (item.Unidades < 10)
                {
                    Mart.AddReporte(item);
                }
            }

            Reporte frmReporte = new Reporte();
            frmReporte.ShowDialog();

        }

        private void nuevoCienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmACliente frmACliente = new FrmACliente();
            frmACliente.ShowDialog();
        }

        private void comprasEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrnComprasEmpleados frnComprasEmpleados = new FrnComprasEmpleados();
            frnComprasEmpleados.ShowDialog();
        }


        private void EliminarArticulo(Object sender, DataGridViewCellMouseEventArgs e)
        {
            Compras.Eliminar(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString()));

            this.Caltulo();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EliminarArticulo(sender, e);
        }

        private void Caltulo()
        {
            Compras.totalCompra = 0;
            foreach (Producto item in Compras.View())
            {
                Compras.totalCompra = Compras.totalCompra + (item.Unidades * item.Precio);
            }
            if (label2.Text.Contains("Simpson"))
            {
                Compras.totalCompra = Compras.totalCompra - ((Compras.totalCompra) * 0.13F);
                lblTotal.Text = "Descuento 13%" + Compras.totalCompra.ToString();
            }
            else
            {
                lblTotal.Text = Compras.totalCompra.ToString();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Compras.View();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ndni Nombre\n111 Abu Empleado\n222 Mike Empleado\n333 Homero Simpson\n444 Bart Simpson\n555 Milhouse Van Houten ");
        }
    }
}
