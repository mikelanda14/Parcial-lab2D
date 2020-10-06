using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Invetario
    {
        static List<Producto> inventario;

        
        /// <summary>
        /// Inicializa la lista inventario para la clase statica inventario
        /// </summary>
        
        static Invetario()
        {
            inventario = new List<Producto>();
        }
        #region Metodos
        /// <summary>
        /// Agrega productos a la lista invectorio para controlar el stock
        /// </summary>
        /// <param name="producto"></param>
        public static void Add(Producto producto)
        {
            inventario.Add(producto);
        }
        /// <summary>
        /// Devuelve la lista completa del stock en existencia
        /// </summary>
        /// <returns></returns>
        public static List<Producto> View()
        {
            return Invetario.inventario;

        }
        /// <summary>
        /// Devuevel la cantidad de unidades de un producto en en el stock. buscandolo mediate su codigo de producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static int GetUnidades(int codigo)
        {
            for (int i = 0; i < inventario.Count; i++)
            {
                if (codigo == inventario[i].Codigo)
                {
                    return inventario[i].Unidades;
                }

            }
            return 0;
        }

        /// <summary>
        /// Cambia la cantidad de unidades de un articulo buscandolo mediante su codigo de producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="unidades"></param>
        public static void ModificacionLista(int codigo, int unidades)
        {


            for (int i = 0; i < inventario.Count; i++)
            {
                if (codigo == inventario[i].Codigo)
                {
                    inventario[i].SetUnidades = inventario[i].Unidades + unidades;
                }
            }

        }
       
        #endregion
    }
}
