using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Implementacion de la interfaz IArchivo para guardar datos sin retorno
        /// </summary>
        /// <param name="archivo">Path al directorio de guardado y nombre del archivo</param>
        /// <param name="datos">Datos a guardar</param>
        public void Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter pedido = new StreamWriter(archivo))
                {
                    pedido.Write(datos);
                }
            }
            catch (Exception e)
            {

                throw new ArchivoExeption(e);
            }
        }


        /// <summary>
        /// Implementacion de la Interfaz IArchivo para leer Datos 
        /// </summary>
        /// <param name="archivo">path al lugar donde se encentra el archivo</param>
        /// <param name="datos">datos a leer</param>
        /// <returns>deberia retornar un  string , pero ni lo nesecito</returns>
        /// <returns>esta asi que lo deje por defatul para que no rompa.</returns>
        public string Leer(string archivo, string datos)
        {
            throw new NotImplementedException();
        }
    }
}
