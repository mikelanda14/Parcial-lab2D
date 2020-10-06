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
    public partial class FrmLogin : Form
    {
        

        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLoging_Click(object sender, EventArgs e)
        {
            
            
            IngresoASistema(txtUsuario.Text.ToString(), txtClave.Text.ToString());

            Limpiar();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            this.txtClave.Clear();
            this.txtUsuario.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void IngresoASistema(string usuario,string clave)
        {
            if (Validaciones.GetClave(usuario) == clave)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal(usuario);
                
                frmPrincipal.ShowDialog();

            }
            else
            {
                MessageBox.Show("Clave o usuario incorrecto");
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "abu";
            this.txtClave.Text = "123";
        }
    }
}
