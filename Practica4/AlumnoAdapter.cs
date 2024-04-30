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
        IAlumno alumno;
        public AlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }
        public IAlumno getAlumno()
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
            return this.alumno.sosIgual((Comparable)((AlumnoAdapter)student).getAlumno());
        }
        public bool lessThan(Student student)
        {
            return this.alumno.sosMenor(((Comparable)student));
        }
        public bool greaterThan(Student student)
        {
            return this.alumno.sosMayor(((Comparable)student));
        }
    }
}
