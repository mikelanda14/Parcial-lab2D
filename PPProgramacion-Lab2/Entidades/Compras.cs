using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Compras
    {
        #region Atributos


        static List<Producto> inventario;
        public static float totalCompra;
        #endregion

        #region Construtor

        /// <summary>
        /// Inicializa la lista inventario
        /// </summary>
        static Compras()
        {
            inventario = new List<Producto>();


        }
        #endregion

        #region Metodos

        /// <summary>
        /// Agrega un producto a la lista inventario
        /// </summary>
        /// <param name="producto"></param>
        public static void Add(Producto producto)
        {
            inventario.Add(producto);
        } 

        /// <summary>
        /// Permite modificar la cantidad de unidades en la lista
        /// </summary>
        /// <param name="codigo"></param>
        public static void ModificacionLista(int codigo)
        {


            for (int i = 0; i < inventario.Count; i++)
            {
                if (codigo == inventario[i].Codigo)
                {
                    inventario[i].SetUnidades = inventario[i].Unidades + 1;
                }
            }

        }
        /// <summary>
        ///     Vacia las lista de compras  por completo.
        /// </summary>
        public static void LimpiarLista()
        {
            inventario.Clear();
        }
        /// <summary>
        /// Devuelve la lista completa de Compras
        /// </summary>
        /// <returns></returns>
        public static List<Producto> View()
        {
            return Compras.inventario;

        }
        /// <summary>
        /// Verigica si un producto esta en la lista de compras buscandolo con el codigo del mismo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool Existe(int codigo)
        {
            bool flag = false;
            foreach (Producto item in inventario)
            {


                if (codigo == item.Codigo)
                {
                    flag = true;
                }

            }
            return flag;
        }
        /// <summary>
        /// Obtiene la cantidad de unidades de un determinado producto buscandolo mediante el codigo del mismo.
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
        /// Muestra todos los datos de todos los productos contenidos en la lista.
        /// </summary>
        /// <returns></returns>
        public static string mostar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recibo Completo de Apu's Mart");
            foreach (var item in inventario)
            {
                sb.AppendLine(item.DatosDeProducto());

            }

            sb.AppendLine($"Total Abonado{totalCompra.ToString()}");
            sb.AppendLine($"--------------------------------------");
            return sb.ToString();
        }
        public static void Eliminar(int codigo)
        {

            for (int i = 0; i < inventario.Count; i++)
            {
                if (inventario[i].Codigo == codigo)
                {
                    inventario.RemoveAt(i);
                }
            }
        }

        #endregion

    }
}
