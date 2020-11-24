using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Exepciones;
using System.Threading;

namespace Entidades
{
   public static class Delivery
    {/// <summary>
    /// Metodo el cual Simula un repartidor tomando el pedido listo y llevandolo a una dirrecion especificada en el documento
    /// mueve el archivo con el nombre del cliente que realizo  la compra.
    /// </summary>
    /// <param name="origen"></param>
    /// <param name="destino"></param>
        public static void DeliveryPedido(string origen,string destino)
        {
            try
            {
                
                Thread.Sleep(5000);
                File.Move(AppDomain.CurrentDomain.BaseDirectory+origen+".txt", AppDomain.CurrentDomain.BaseDirectory+@"..\Entregado_"+ destino +".txt");
                
                
            }
            catch (Exception e)
            {

                throw new ArchivoExeption (e) ;
            }
            
        }

    }
}
