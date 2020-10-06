using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase tipo Producto para llevar inventario.
    /// </summary>
    public class Producto
    {
        #region Atributos

        
        protected int codigo;
        protected string marca;
        protected string nombre;
        protected float precio;
        protected int cantidadUnidades;
        #endregion

        #region Contructor

        /// <summary>
        /// Contructor del producto.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidadUnidades"></param>
        public Producto(int codigo, string marca, string nombre, float precio, int cantidadUnidades)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidadUnidades = cantidadUnidades;

        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Retorna el codigo del producto
        /// </summary>
        public int Codigo { get { return this.codigo; } }
        /// <summary>
        /// retorna la mara del producto
        /// </summary>
        public string Marca { get { return this.marca; } }
        /// <summary>
        /// retorna el nombre del producto
        /// </summary>
        public string Nombre { get { return this.nombre; } }
        /// <summary>
        /// retorna las El numero de unidades del producto en lista.
        /// </summary>
        public int Unidades { get { return this.cantidadUnidades; } }
        /// <summary>
        /// retorna el precio del producto
        /// </summary>
        public float Precio { get { return this.precio; } }
        /// <summary>
        /// cambia el numero de unidades del producto en existencia.
        /// </summary>
        public int SetUnidades { set { this.cantidadUnidades = value; } }

        /// <summary>
        /// Propiedad virtual para ser sobre escrita por clases deribadas Opcionalmente.
        /// </summary>
        public virtual Categoria CategoriaP{ get; }

        #endregion

        #region Metodos

        /// <summary>
        ///  Devuelve un string con todos los atributos de la clase.
        /// </summary>
        /// <returns></returns>
        public virtual string DatosDeProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Codigo :{this.codigo.ToString(),10}");
            sb.Append($" Marca :{this.marca,10}");
            sb.Append($" Nombre :{this.nombre.ToString(),10}");
            sb.Append($" Unidades :{this.Unidades.ToString(),10}");
            sb.Append($" Precio :{this.precio.ToString(),5}");

            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga ToString  devuelve todos los atributos de la clase.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.DatosDeProducto();
        }
        #endregion

        public enum Categoria
        {
            Bebidas,
            Comestible,
            Electronico,
            Perfumeria

        }
    }
}
