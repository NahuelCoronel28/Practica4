using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal interface ComparacionAlumno
    {
        bool sosIgual(Alumno a, Alumno b);
        bool sosMenor(Alumno a, Alumno b);
        bool sosMayor(Alumno a, Alumno b);
    }
}
