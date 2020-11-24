using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Exepciones;

namespace Entidades
{
    public   class Restaurant
    {

        #region Atributos

        
        static List<Producto> ventas;
        static List<Pedido> pedidos;
        static List<Pedido> pedidosListos;
        static List<Producto> menu;
        public static int NumeroPedido;

        #endregion

        #region Constructores

        
        /// <summary>
        /// Constructor por defecto para potencialemnte serializar la clase.
        /// </summary>
        public Restaurant()
        {

        }

        /// <summary>
        /// Constructor statico para que inicialize todas las listas usadas y el contador numero pedido
        /// </summary>
        static Restaurant()
        {
            ventas = new List<Producto>();
            menu = new List<Producto>();
            pedidos = new List<Pedido>();
            pedidosListos = new List<Pedido>();
            Restaurant restaurant = new Restaurant();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// /Agrega producto a lista de tipo producto utilizada para seguir la venta.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public static void AgregarVenta(int codigo,string descripcion,float precio)
        {
            Restaurant.ventas.Add(new Producto(codigo,descripcion,precio));
        }
        /// <summary>
        /// Agrega productos a la lista utilizada para mostar el menu disponible al cajero
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public static void AgregarMenu(int codigo, string descripcion, float precio)
        {
            Restaurant.menu.Add(new Producto(codigo, descripcion, precio));
        }
        /// <summary>
        /// Metodo utizado para genara un pedido al momento que se cobra la venta.envia los parametros. y genera el objeto
        /// </summary>
        /// <param name="importeTotal"></param>
        /// <param name="descripcion"></param>
        /// <param name="nombreCliente"></param>
        /// <param name="numeroPedido"></param>
        /// <param name="delivery"></param>
        public static void AgregarPedido(float importeTotal, string descripcion, string nombreCliente, int numeroPedido,bool delivery)
        {
            Restaurant.pedidos.Add(new Pedido(importeTotal, descripcion, nombreCliente ,numeroPedido,delivery));
            
        }
        /// <summary>
        /// sobrearga del metodo anterior agrega pedidodo a la lista de pedidos reciviendo un objeto
        /// </summary>
        /// <param name="pedido"></param>
        public static void AgregarPedidoObjeto(Pedido pedido)
        {
            Restaurant.pedidos.Add(pedido);
            
        }
        /// <summary>
        /// Agrega el objeto pedido a la lista de pedidos listos , para vizualizar en el Form los pedidos ya completados.
        /// </summary>
        /// <param name="pedido"></param>
        public static void AgregarPedido(Pedido pedido)
        {
            Restaurant.pedidosListos.Add(pedido);
            

        }
        /// <summary>
        /// Metodo Simula la entrega a los exelenticimos clientes del restaurant , en forma aleatoria simulando clientes atentos y no atentos al anuncio
        /// </summary>
        public static  void PedidoEntregado()
        {
            if (pedidosListos.Count() > 0)
            { 
                Random random = new Random();
                int numero=random.Next(Restaurant.pedidosListos.FirstOrDefault().NumeroPedido,Restaurant.NumeroPedido);
                foreach  (Pedido item in pedidosListos)
                {
                    if (item.NumeroPedido == numero)
                    {
                        if (item.GetDelivery())
                        {
                            Delivery.DeliveryPedido(item.NombreCliente, item.NombreCliente);
                        }
                        pedidosListos.Remove(item);
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Metodo simula la fabricacion del pedido y pasado a lista para retirar. siguendo un orden primero entra y primero sale
        /// </summary>
        public static void PedidoListo()
        {
            
            try
            {
                
                if (Restaurant.viewPedidos().Count>0)
                {

               
                int numero = Restaurant.pedidos.FirstOrDefault().NumeroPedido;
                
                foreach (Pedido item in pedidos)
                {
                    if (item.NumeroPedido == numero)
                    {
                        
                        Restaurant.pedidosListos.Add(item);
                        Restaurant.pedidos.Remove(item);
                        
                        break;
                    }
                }
                }
            }
            catch (Exception e)
            {
                throw new HilosException (e);
                
            }
         
        }

        /// <summary>
        /// Metodo devuelve lista de producto utilizada para menu
        /// </summary>
        /// <returns></returns>
        public static List<Producto> viewMenu()
        {
            return menu;
        }
        /// <summary>
        /// Metodo devuelve lista productos utilizada para venta
        /// </summary>
        /// <returns></returns>
        public static List<Producto> viewVentas()
        {
            return ventas;
        }
     
        /// <summary>
        /// metodo devuelve lista pedidos utilizada por pantalla en preparacion
        /// </summary>
        /// <returns></returns>
        public static List<Pedido> viewPedidos()
        {
            return pedidos;
        } 
        /// <summary>
        /// Metodo devuelve lista de pedido utilizada por pantalla pedidos a entregar
        /// </summary>
        /// <returns></returns>
        public static List<Pedido> viewPedidosListos()
        {
            return pedidosListos;
        }

        /// <summary>
        /// Metodo utilizado Limpia la pantalla de venta del cajero
        /// </summary>
        public static void LimpiarVentas()
        {
            ventas.Clear();
        }

        public static string DescripcionPedido()
        {
            StringBuilder sb = new StringBuilder();
            foreach  (Producto item in ventas)
            {
                sb.AppendLine(item.Descripcion);
            }

            return sb.ToString(); 
        } 
        /// <summary>
        /// MEtodo genera un sting con todos los datos del pedido y la direccion.
        /// </summary>
        /// <param name="direcion"></param>
        /// <returns></returns>
        public static string PedidoRepartidor(string direcion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos para Entregar :"+direcion.ToString());
            foreach  (Producto item in ventas)
            {
                sb.AppendLine(item.Descripcion+" "+item.Precio);
            }
            sb.AppendLine($"             "+ CalculoImportePedido().ToString());
            
            return sb.ToString(); 
        }
        /// <summary>
        /// Metodo utilziado para calcular el inporte total.
        /// </summary>
        /// <returns>retorna un float</returns>
        public static float CalculoImportePedido()
        {
            float ImporteTotal = 0;
            foreach (Producto item in Restaurant.viewVentas())
            {
                ImporteTotal = item.Precio + ImporteTotal;

            }
            return ImporteTotal;
        }
        public static void Guardar(string nombreCliente,string direccion)
        {
            Texto texto = new Texto();
            texto.Guardar(AppDomain.CurrentDomain.BaseDirectory + @nombreCliente + ".txt", PedidoRepartidor(direccion));
        }
        /// <summary>
        /// Metodo utilizado para precargar los pedidos en la pantalla en preparacion
        /// </summary>
        public static void PreCargadoPedidos()
        {
            try
            {
                
                List<Pedido> recuperarPedidos = new List<Pedido>();
                Xml<List<Pedido>> archivoXML = new Xml<List<Pedido>>();
               
                   pedidos= archivoXML.Leer(AppDomain.CurrentDomain.BaseDirectory + @"pedidosPreCarga0000.xml" , recuperarPedidos);
                

                
                  
            }
            catch (Exception e)
            {

               throw e;
            }
         
            
        }
        /// <summary>
        /// Metodo utilizado una sola vez para guardar Serializar lista en preparacion .  
        /// </summary>
        public static void GuardarXml()
        {
            Xml<List<Pedido>> archivoXML = new Xml<List<Pedido>>();
               archivoXML.Guardar(AppDomain.CurrentDomain.BaseDirectory + @"pedidosPreCarga0000.xml",Restaurant.viewPedidos());
          

        }
        #endregion


    }
}
