using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Abstracta base para control del personal y clientes.
    /// </summary>
    abstract public class Persona
    {
        #region Atributos

        
        protected int dni;
        protected string nombre;
        #endregion

        #region Contructor

        /// <summary>
        /// contructor para clase tipo persona.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// propiedad para ser sobre escrita por clase deribada, retorna el numero de dni
        /// </summary>
        
        public abstract int GetDni { get; }
        /// <summary>
        /// propiedad para ser sobre escrita por clase deribada, retorna el nombre
        /// </summary>
        public abstract string GetNombre { get; }
        #endregion
    }
}
