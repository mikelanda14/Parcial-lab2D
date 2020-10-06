using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Atributos

        
        string clave;
        string usuario;
        static List<String> compras;
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor que reutiliza codigo enviadolo los parametros a la clase base.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="clave"></param>
        /// <param name="usuario"></param>

        public Empleado(int dni, string nombre, string clave, string usuario) : base(dni, nombre)
        {
            
            this.clave = clave;
            this.usuario = usuario;
            compras = new List<string>();
        }

        #endregion

        #region Propiedades

       /// <summary>
       /// retorna la clave del usuario
       /// </summary>
        public string GetClave { get { return this.clave; } }

        /// <summary>
        /// retorna el usuario
        /// </summary>
        public string GetUser { get { return this.usuario; } }
        /// <summary>
        /// retorna el dni del usuario
        /// </summary>
        public override int GetDni { get { return this.dni; } }
        /// <summary>
        /// retorna el nobre del usuario/empleado
        /// </summary>
        public override String GetNombre { get { return this.nombre; } }
        #endregion

        #region Metodos

        /// <summary>
        /// Guarda el string generado por una venta  en la lista , guardando la historia de compras de los empleados.
        /// </summary>
        /// <param name="Venta"></param>
        public void Setventa(string Venta) { Empleado.compras.Add(Venta); }
        
        /// <summary>
        /// Muestra las compras almacenadas en el registro historico de compras de los empleados.
        /// </summary>
        /// <returns></returns>
        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Compras Realizadas por el empleado Empleado :{this.nombre}");
            foreach (var item in compras)
            {

                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion
    }

}
