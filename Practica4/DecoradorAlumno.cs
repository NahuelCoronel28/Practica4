using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal abstract class DecoradorAlumno : IAlumno,Comparable
    {
        IAlumno auxIAlumno;
        public DecoradorAlumno(IAlumno a)
        {
            this.auxIAlumno = a;
        }
        public string getNombre()
        {
            return auxIAlumno.getNombre();
        }
        public int getLegajo()
        {
            return this.auxIAlumno.getLegajo();
        }
        public int getPromedio()
        {
            return this.auxIAlumno.getPromedio();
        }
        public void setComparadorAlumno(ComparacionAlumno aux)
        {
            this.auxIAlumno.setComparadorAlumno(aux);
        }

        public void setCalificacion(int calificacion_aux)
        {
            this.auxIAlumno.setCalificacion(calificacion_aux);
        }
        public int getCalificacion()
        {
            return this.auxIAlumno.getCalificacion();
        }
        public bool sosIgual(Comparable c)
        {
            return true;
        }
        public bool sosMenor(Comparable c)
        {
            return true;
        }
        public bool sosMayor(Comparable c)
        {
            return true;
        }

        public void prestarAtencion()
        {
            this.auxIAlumno.prestarAtencion();
        }
        public void distraerse()
        {
            this.auxIAlumno.distraerse();
        }
        public void actualizar(Observado observado)
        {
            this.auxIAlumno.actualizar(observado);
        }
        public string ToString()
        {
            return this.auxIAlumno.ToString();
        }
        public int responderPregunta(int pregunta)
        {
            return this.auxIAlumno.responderPregunta(pregunta);
        }

        public virtual string mostrarCalificacion()
        {
            return this.auxIAlumno.mostrarCalificacion();
        }
    }
}
