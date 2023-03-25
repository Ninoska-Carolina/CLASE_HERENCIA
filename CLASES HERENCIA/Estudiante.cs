using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES_HERENCIA
{
    internal class Estudiante:Usuario
    {
    public decimal Edad { get; set; }
    public override string ToString()
    {

        return $"CUENTA: {Cuenta} | Pass:{Password} | Nombre:{Nombre} | Matricula:{Matricula} | Edad:{Edad}";

    }
}
}
