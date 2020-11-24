using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class ExtensionRestaurant
    {
        /// <summary>
        /// Extiende la funcinalidad del metodo CalculoImporte en el objeto restaurant. 
        /// Redondea a dos decimales
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns></returns>
        public static float ExtensionCalculoImporte(this Restaurant restaurant)
        {
           
           double aux= Restaurant.CalculoImportePedido();
            float auxImporte=(float)(Math.Round(aux, 2));
            return auxImporte;


        }
      
    }
}
