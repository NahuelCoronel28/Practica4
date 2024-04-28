using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class StudentsFactory : FabricaDeAlumnos
    {
        Alumno alumno;
        public StudentsFactory(AlumnoAdapter alumno2)
        {
            this.alumno = alumno2.getAlumno();
        }
        public void creadorDeDecoradores()
        {
            IAlumno alumno3 = ((Alumno)this.alumno);
            IAlumno decorador = new DecoradoConLegajo(alumno3);
            IAlumno decorador2 = new DecoradoConLetras(decorador);
            IAlumno decorador3 = new DecoradoConPromocion(decorador2);
            IAlumno decorador4 = new DecoradoConRecuadro(decorador3);
            string resultado = decorador4.mostrarCalificacion();
            Console.WriteLine(resultado);
        }
    }
}
