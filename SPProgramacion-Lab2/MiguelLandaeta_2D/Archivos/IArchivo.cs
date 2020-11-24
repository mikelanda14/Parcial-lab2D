using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Metodo interfaz para guardar datos sin retorno
        /// </summary>
        /// <param name="archivo">Path al directorio de guardado y nombre del archivo</param>
        /// <param name="datos">Datos a guardar</param>
        void Guardar(string archivo, T datos);

        /// <summary>
        /// Metodo Interfaz para leer Datos
        /// </summary>
        /// <param name="archivo">path al lugar donde se encentra el archivo</param>
        /// <param name="datos">datos a leer</param>
        /// <returns>retorna el objeto con los datos</returns>
        T Leer(string archivo, T datos);
    }
}
