using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal interface IAlumno
    {
        public string getNombre();
        public int getLegajo();
        public int getPromedio();
        public void setComparadorAlumno(ComparacionAlumno aux);
        
        public void setCalificacion(int calificacion_aux);
        public int getCalificacion();
        public  bool sosIgual(Comparable c);
        public bool sosMenor(Comparable c);
        public bool sosMayor(Comparable c);

        public void prestarAtencion();
        public void distraerse();
        public void actualizar(Observado observado);
        public string ToString();
        public int responderPregunta(int pregunta);

        public string mostrarCalificacion();
    }
}
