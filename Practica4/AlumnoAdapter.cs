using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;
namespace Practica4
{
    internal class AlumnoAdapter : Student
    {
        Alumno alumno;
        public AlumnoAdapter(Alumno alumno)
        {
            this.alumno = alumno;
        }
        public Alumno getAlumno()
        {
            return alumno;
        }
        public string getName()
        {
            return this.alumno.getNombre();
        }
        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }
        public void setScore(int score)
        {
            this.alumno.setCalificacion(score);
        }
        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }
        public bool equals(Student student)
        {
            return this.alumno.sosIgual(((AlumnoAdapter)student).getAlumno());
        }
        public bool lessThan(Student student)
        {
            return this.alumno.sosMenor(((AlumnoAdapter)student).getAlumno());
        }
        public bool greaterThan(Student student)
        {
            return this.alumno.sosMayor(((AlumnoAdapter)student).getAlumno());
        }
    }
}
