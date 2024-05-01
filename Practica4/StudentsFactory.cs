using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class StudentsFactory : FabricaDeAlumnos
    {
        IAlumno alumno;
        public StudentsFactory(AlumnoAdapter alumno2)
        {
            this.alumno = alumno2.getAlumno();
        }
        public AlumnoAdapter creadorDeDecoradores()
        {
            //IAlumno alumno3 = ((Alumno)this.alumno);
            IAlumno decorador = new DecoradoConLegajo(alumno);
            IAlumno decorador2 = new DecoradoConLetras(decorador);
            IAlumno decorador3 = new DecoradoConPromocion(decorador2);
            IAlumno decorador4 = new DecoradoConRecuadro(decorador3);
            Student alumnofinal = new AlumnoAdapter(decorador4);
            return ((AlumnoAdapter)alumnofinal);
        }
    }
}
