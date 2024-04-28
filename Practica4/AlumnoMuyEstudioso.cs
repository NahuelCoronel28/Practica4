using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre_alumno, int dni_alumno, int legajo, int promedio) : base(nombre_alumno, dni_alumno, legajo, promedio)
        {

        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta%3;
        }
    }
}
