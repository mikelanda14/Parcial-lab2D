using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Perfumeria:Producto
    {
        #region Contructor

        /// <summary>
        /// Contructor de la clase perfumeria, reutiliza codigo enviando los parametros a la clase base
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Perfumeria(int codigo, string marca, string nombre, float precio, int cantidad) : base(codigo, marca, nombre, precio, cantidad)
        {

        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve la categoria del articulo.
        /// </summary>
        public override Categoria CategoriaP { get { return Categoria.Perfumeria; } }
        /// <summary>
        /// Descripcion del articulo
        /// </summary>
        public int Distancia { get { return 10; } }
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
            sb.Append($"Distancia de alcanze del perfume: {this.Distancia.ToString()}MTs");

            return sb.ToString();
        }

        #endregion

    }
}
