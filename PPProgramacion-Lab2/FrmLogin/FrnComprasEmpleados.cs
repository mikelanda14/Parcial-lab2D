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

namespace FrmLogin
{
    public partial class FrnComprasEmpleados : Form
    {
        public FrnComprasEmpleados()
        {
            InitializeComponent();
        }

        private void FrnComprasEmpleados_Load(object sender, EventArgs e)
        {


            foreach (var item in Mart.View())
            {
                richTextBox1.Text = item.mostrar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
