using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        #region Atributos

        
        int codigo;
        string descripcion;
        float precio;
        #endregion

        #region Costructor

        /// <summary>
        /// Inicializa con los parametros el objeto producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public Producto(int codigo, string descripcion, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedades generadas para que pueda mostrar en la lista del menu
        /// </summary>
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que puestra datos del producto Al pedo por que no lo termine usando.
        /// </summary>
        /// <returns>Un string con el godigo la descriccion y el precio.</returns>
        private string MostarProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Codigo.ToString()} {this.Descripcion.ToString()} {this.Precio.ToString()}" );
            return sb.ToString();
        }
        /// <summary>
        /// Override de To string para el objeto producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostarProducto();
        }
        #endregion
    }
}
