using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class ColaExcetion :Exception
    {
        public  ColaExcetion(Exception innerException) :base(innerException.Message)
        {

        }
    }
}
