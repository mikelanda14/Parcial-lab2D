using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Exepciones;


namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Implementaicion del metodo Guardar de la Interfaz IArchivo
        /// </summary>
        /// <param name="archivo">Directorio donde guarda junto con el nombre del archivo</param>
        /// <param name="datos">datos a guardar</param>
        public void Guardar(string archivo, T datos)
        {

            try
            {


                using (XmlTextWriter newTextWriter = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer archivoXml = new XmlSerializer(typeof(T));
                    archivoXml.Serialize(newTextWriter, datos);


                }

            }
            catch (Exception e)
            {

                throw new ArchivoExeption(e);

            }


        }
        /// <summary>
        /// Implementacion de la interfaz IArchivo del metodo leer
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>objeto que contiene los datos del archivo</returns>
        public T Leer(string archivo, T datos)
        {

            try
            {


                using (XmlTextReader textReader = new XmlTextReader(archivo))
                {
                    XmlSerializer archivoXml = new XmlSerializer(typeof(T));
                    datos = (T)archivoXml.Deserialize(textReader);
                }


                return datos;
            }
            catch (Exception e)
            {

                throw new ArchivoExeption(e);
            }

        }
    }
}
