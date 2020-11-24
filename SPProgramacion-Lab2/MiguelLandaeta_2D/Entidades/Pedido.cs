using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        #region Atributos

        
        float importeTotal;
        string descripcion;
        string nombreCliente;
        int numeroPedido;
        bool delivery;
        #endregion


        #region Constructor

        
        /// <summary>
        /// Construcot vacio para poder Serializar.
        /// </summary>
        public Pedido()
        {

        }
        /// <summary>
        /// Constructor el cual completa todod los atributos.
        /// </summary>
        /// <param name="importeTotal"></param>
        /// <param name="descripcion"></param>
        /// <param name="nombreCliente"></param>
        /// <param name="numeroPedido"></param>
        /// <param name="delivery"></param>
        public Pedido(float importeTotal, string descripcion, string nombreCliente,int numeroPedido,bool delivery)
        {
            this.importeTotal = importeTotal;
            this.descripcion = descripcion;
            this.nombreCliente = nombreCliente;
            this.numeroPedido = numeroPedido;
            this.delivery = delivery;
        }

        #endregion


        #region Propiedades

        
        /// <summary>
        /// propiedad que devuelve descripccion del pedido y
        /// </summary>
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }

        public int NumeroPedido { get => numeroPedido; set => numeroPedido = value; }

        #endregion

        #region Metodos

        
        /// <summary>
        /// Metodo el cual devuelve el valor de la variable Delivery
        /// </summary>
        /// <returns>retorna Delivery</returns>
        public bool GetDelivery()
        {
            return this.delivery;
        }
        /// <summary>
        /// Metodo el cual genera un string contiene todos los productos en el pedido.
        /// </summary>
        /// <returns>retorna string</returns>
        public  string DescripcionPedido()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo    Descripcion     Precio");
            foreach (Producto item in Restaurant.viewVentas())
            {
                sb.AppendLine(item.ToString());
            }

            
            return sb.ToString() ; 
        }
        /// <summary>
        /// Metodo sobrecarga de Descricion pedido utilizado para agregar dirrecion para delivers
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns>retorna string</returns>
        public string DescripcionPedido(string direccion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Direccion para entrega {direccion.ToString()}");
            sb.AppendLine(this.DescripcionPedido());
            return sb.ToString();
        }

        #endregion
    }
}
