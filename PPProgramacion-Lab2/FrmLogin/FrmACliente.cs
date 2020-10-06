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
    public partial class FrmACliente : Form
    {
        public FrmACliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni;
            int.TryParse(txtDni.Text.ToString(), out dni);
            Mart.AddCliente(new Cliente(dni, txtNombre.Text.ToString()));
            this.txtNombre.Clear();
            this.txtDni.Clear();
            this.Close();
        }
    }
}
