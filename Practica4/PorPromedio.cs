using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class PorPromedio
    {
        public bool sosIgual(Alumno a, Alumno b)
        {
            return a.getPromedio() == b.getPromedio();
        }
        public bool sosMenor(Alumno a, Alumno b)
        {
            return a.getPromedio() < b.getPromedio();
        }
        public bool sosMayor(Alumno a, Alumno b)
        {
            return a.getPromedio() > b.getPromedio();
        }
    }
}
