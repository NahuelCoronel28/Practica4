using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class PorNombre : ComparacionAlumno
    {
        public bool sosIgual(Alumno a, Alumno b)
        {
            return a.getNombre().Length == b.getNombre().Length;
        }
        public bool sosMenor(Alumno a, Alumno b)
        {
            return a.getNombre().Length < b.getNombre().Length;
        }
        public bool sosMayor(Alumno a, Alumno b)
        {
            return a.getNombre().Length > b.getNombre().Length;
        }
    }
}
