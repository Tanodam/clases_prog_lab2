using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidException : Exception
    {
        public PatenteInvalidException(string mensaje) : this(mensaje, null)
        {

        }
        public PatenteInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
