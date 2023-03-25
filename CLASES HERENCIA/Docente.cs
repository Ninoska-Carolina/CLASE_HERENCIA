using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES_HERENCIA
{
    internal class Docente: Usuario

    {
        public decimal Sueldo { get; set; }
        public override string ToString()
        {

            return $"CUENTA: {Cuenta} | Pass:{Password} | Nombre:{Nombre} | Sueldo:{Sueldo} ";

        }
    }
}
