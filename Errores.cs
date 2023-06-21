using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Programacion_I
{
    public class DuplicatedSymbolsException : Exception
    {
        public DuplicatedSymbolsException() : base() { }
        public DuplicatedSymbolsException(string message) : base(message) { }
        public DuplicatedSymbolsException(string message, Exception inner) : base(message, inner) { }
    }
}
