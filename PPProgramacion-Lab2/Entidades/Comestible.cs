using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comestible:Producto
    {
        #region Contructor
        /// <summary>
        /// Construtor que reutiliza codigo enviadolo los parametros a la clase base.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>

        public Comestible(int codigo, string marca, string nombre, float precio, int cantidad) : base(codigo, marca, nombre, precio, cantidad)
        {

        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Descripcion del articulo
        /// </summary>
        public string Fecha{ get { return "Ornamental nunca vencess"; } }
        /// <summary>
        ///  Devuelve la categoria del articulo.
        /// </summary>
        public override Categoria CategoriaP { get { return Categoria.Comestible; } }
        #endregion

        #region Metodo


        /// <summary>
        /// Sobre escribe el metodo mostrar producto padre tomando el string que produce y agregando una line mas que describe el articulo
        /// </summary>
        /// <returns></returns>
        public override string DatosDeProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.DatosDeProducto());
            sb.Append($"Tamaño de bebida {this.Fecha.ToString()}");

            return sb.ToString();

        }
        #endregion
    }
}
