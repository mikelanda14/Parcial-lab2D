﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exepciones
{
    public class ArchivoExeption:Exception
    {
        public ArchivoExeption(Exception innerException):base(innerException.Message)
        {

        }
    }
}
