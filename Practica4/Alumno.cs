using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Alumno : Persona,Observador,IAlumno
    {
        int legajo;
        int promedio;
        ComparacionAlumno comparadorAlumno;
        int calificacion;
        public Alumno(string nombre_alumno, int dni_alumno, int legajo, int promedio) : base(nombre_alumno, dni_alumno)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            comparadorAlumno = new PorDNI();
            int calificacion = 0;
        }
        public IAlumno getAlumno()
        {
            return ((Alumno)this);
        }
        public int getLegajo()
        {
            return legajo;
        }
        public int getPromedio()
        {
            return promedio;
        }
        public void setComparadorAlumno(ComparacionAlumno aux)
        {
            comparadorAlumno = aux;
        }
        public override string ToString()
        {
            return "Nombre: " + this.getNombre() + " ; DNI: " + this.getDni().ToString() + " ; Legajo " + this.getLegajo().ToString() + " ; Promedio: " + this.getPromedio().ToString();
        }
        public void setCalificacion(int calificacion_aux)
        {
            calificacion = calificacion_aux;
        }
        public int getCalificacion()
        {
            return calificacion;
        }
        public override bool sosIgual(Comparable c)
        {
            return comparadorAlumno.sosIgual(this, ((Alumno)((IAlumno)c).getAlumno()));
        }
        public override bool sosMenor(Comparable c)
        {
            return comparadorAlumno.sosMenor(this, ((Alumno)((IAlumno)c).getAlumno()));
        }
        public override bool sosMayor(Comparable c)
        {
            return comparadorAlumno.sosMayor(this, ((Alumno)((IAlumno)c).getAlumno()));
        }

        public void prestarAtencion()
        {
            Console.WriteLine("Prestando atencion");
        }
        public void distraerse()
        {
            string[] frasesDeAlumno = new string[] { "Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel" };
            Random random = new Random();
            int indice = random.Next(0, frasesDeAlumno.Length);
            Console.WriteLine(frasesDeAlumno[indice]);
        }
        public void actualizar(Observado observado)
        {
            Profesor profesor = ((Profesor)observado);
            if (profesor.getEstado() == "Hablando de algún tema")
            {
                this.prestarAtencion();
            }
            if (profesor.getEstado() == "Escribiendo en el pizarrón")
            {
                this.distraerse();
            }
        }

        public virtual int responderPregunta(int pregunta)
        {
            return new Random().Next(0, 3);
        }

        public string mostrarCalificacion()
        {
            return  this.getNombre() + "    " + this.getCalificacion(); 
        }
    }
}
