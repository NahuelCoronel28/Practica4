using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;
namespace Practica4
{
    internal class AlumnoAdapter : Student, Comparable
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
            return this.getAlumno().sosIgual((Comparable)((AlumnoAdapter)student).getAlumno());
        }
        public bool lessThan(Student student)
        {
            return this.getAlumno().sosMenor((Comparable)((AlumnoAdapter)student).getAlumno());
        }
        public bool greaterThan(Student student)
        {
            return this.getAlumno().sosMayor((Comparable)((AlumnoAdapter)student).getAlumno());
        }
        public bool sosIgual(Comparable c)
        {
            return this.getAlumno().sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            return this.getAlumno().sosMenor(c);
        }
        public bool sosMayor(Comparable c)
        {
            return this.getAlumno().sosMayor(c);
        }
    }
}
