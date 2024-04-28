using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class PorLegajo : ComparacionAlumno
    {
        public bool sosIgual(Alumno a, Alumno b)
        {
            return a.getLegajo() == b.getLegajo();
        }
        public bool sosMenor(Alumno a, Alumno b)
        {
            return a.getLegajo() < b.getLegajo();
        }
        public bool sosMayor(Alumno a, Alumno b)
        {
            return a.getLegajo() > b.getLegajo();
        }
    }
}
