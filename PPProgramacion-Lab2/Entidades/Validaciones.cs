using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Para ejecutar algunas validaciones
    /// </summary>
    public class Validaciones
    {
        #region Metodos

        
        /// <summary>
        /// Valida la clave del usuario buscando en la lista por el User Name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string GetClave(string userName)
        {


            foreach (var item in Mart.View())
            {

                if (userName == item.GetUser)
                {
                    return item.GetClave;
                }
            }

            return "clave incorrecta";

        }
        /// <summary>
        /// Valida que un Cliente este Registrado buscandolo por DNI y devolviendo el nombre
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static string ValidarCliente(string dni)
        {

            string aux = "Cliente no registrado";
            foreach (var item in Mart.viewCliente())
            {
                if (dni != string.Empty)
                {
                    if (int.Parse(dni) == item.GetDni)
                    {
                        return item.GetNombre;
                    }
                }

            }

            return aux;
        }
        /// <summary>
        /// Valida si un usuario es empleado atraves del DNI devuelve bool
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static bool ValidarEmpleado(string dni)
        {

            bool aux = false;


            foreach (var item in Mart.View())
            {
                if (dni != string.Empty)
                    if (int.Parse(dni) == item.GetDni)
                    {
                        return true;
                    }

            }

            return aux;
        }
        #endregion
    }
}
