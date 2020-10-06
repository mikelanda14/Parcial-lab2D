using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region Contrutores

        /// <summary>
        /// Construtor que reutiliza codigo enviadolo los parametros a la clase base.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>

        public Cliente(int dni, string nombre) : base(dni, nombre)
        {
            

        }
        #endregion

        #region propiedades

        /// <summary>
        /// devuelve el dni del cliente
        /// </summary>
        public override int GetDni { get { return this.dni; } }
        /// <summary>
        /// devuelve el nombre del cliente
        /// </summary>
        public override String GetNombre { get { return this.nombre; } }
        #endregion


    }
}

