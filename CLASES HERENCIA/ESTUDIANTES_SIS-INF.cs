using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES_HERENCIA
{
    internal class ESTUDIANTES_SIS_INF:Usuario
    {
        public decimal Costo_Matricula { get; set; }
        public override string ToString()
        {

            return $"CUENTA: {Cuenta} | Pass:{Password} | Nombre:{Nombre} | Matricula:{Matricula} | Costo_Matricula:{Costo_Matricula} ";
             
        }
    }
}
