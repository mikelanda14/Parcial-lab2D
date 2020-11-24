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
using System.Threading;
using Exepciones;

namespace FPrincipal
{
    public partial class FrmColaPedidos : Form
    {
        

        
        public FrmColaPedidos()
        {
            InitializeComponent();
            Thread thread = new Thread(ColaRefresh);
            thread.IsBackground = true;
            thread.Start();

            Thread threadB = new Thread(Pedidolisto);
            threadB.IsBackground = true;
            threadB.Start();


            Thread threadD = new Thread(Entrega);
            threadD.IsBackground = true;
            threadD.Start();

           

        }

        private void FrmColaPedidos_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Metodo utilizado pro hilo para regrescar Cola en preparacion
        /// </summary>
        private void ColaRefresh()
        {
            
            try
            {
                bool pepe = true;
                while (pepe == true)
                {
                    Thread.Sleep(1000);
                    DgColaPedidos.RowHeadersVisible = false;
                    DgColaPedidos.Invoke(new Action(() => DgColaPedidos.DataSource = null));
                    DgColaPedidos.Invoke(new Action(() => DgColaPedidos.DataSource = Restaurant.viewPedidos()));


                    DgPListo.RowHeadersVisible = false;
                    DgPListo.Invoke(new Action(() => DgPListo.DataSource = null));
                    DgPListo.Invoke(new Action(() => DgPListo.DataSource = Restaurant.viewPedidosListos()));

                }
            }
            catch (ColaExcetion e)
            {

                throw e;
            }
            
            

            
        }

       /// <summary>
       /// Metodo el cual se ejecuta cuando un pedido esta listo
       /// </summary>
        private void Pedidolisto()
        {
            while (true)
            {
                if (Restaurant.viewPedidos().Count > 0)
                {
                    int numero = Restaurant.viewPedidos().FirstOrDefault().Descripcion.Length;
                    
                    Thread.Sleep(numero  * 150);
                }
                else
                {
                    Thread.Sleep(4000);
                }
                Restaurant.PedidoListo();
                
            }
         
           
        }

        /// <summary>
        /// Metodo utilizado por el hilo para simular el retiro de pedidos listos.
        /// </summary>

        private void Entrega()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(3000);

                    Restaurant.PedidoEntregado();


                }
            }
            catch (Exception)
            {

            }
           
            
        }
    }
}
