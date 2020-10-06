using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebidas :Producto
    {
        #region Contructor
        /// <summary>
        /// conturtor de protucto tipo bebidas, reutiliza codigo enviado los parametros a la clase base
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Bebidas(int codigo,string marca,string nombre,float precio, int cantidad ):base(codigo,marca,nombre, precio,cantidad)
        {

        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelbe una descripcion mas profunda del articulo
        /// </summary>
        public int Capacidad { get { return 330; } }
        /// <summary>
        /// propiedad que devuelve la categoria del articulo.
        /// </summary>
        public override Categoria CategoriaP { get { return Categoria.Bebidas; } }


        #endregion

        #region Metodos
        /// <summary>
        /// sobre escribe el metodo Datatos de producto de la clase base y agrega descripcion mas profunda del  articulo
        /// </summary>
        /// <returns></returns>
        
        public override string DatosDeProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.DatosDeProducto());
            sb.Append($"Tamaño de bebida {this.Capacidad.ToString()}ml");

            return sb.ToString();
            
        }
        #endregion
    }
}
