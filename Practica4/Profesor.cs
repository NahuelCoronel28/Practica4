using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Profesor : Persona, Observado
    {
        int antiguedad;
        List<Observador> listaDeAlumnos;
        string estado;
        public Profesor(string nombre_profesor, int dni_profesor, int antiguedad) : base(nombre_profesor, dni_profesor)
        {
            this.antiguedad = antiguedad;
            this.listaDeAlumnos = new List<Observador>();
            this.estado = "No estoy haciendo nada";
        }
        public int getAntiguedad()
        {
            return antiguedad;
        }
        public List<Observador> getListaDeAlumno()
        {
            return listaDeAlumnos;
        }
        public string getEstado()
        {
            return estado;
        }
        public void setEstado(string estado_aux)
        {
            estado = estado_aux;
        }
        public override string ToString()
        {
            return "Nombre: " + this.getNombre() + " ; DNI: " + this.getDni().ToString() + " ; Antiguedad " + this.getAntiguedad().ToString();
        }
        public override bool sosIgual(Comparable c)
        {
            return this.getDni() == ((Profesor)c).getDni();
        }
        public override bool sosMenor(Comparable c)
        {
            return this.getDni() < ((Profesor)c).getDni();
        }
        public override bool sosMayor(Comparable c)
        {
            return this.getDni() > ((Profesor)c).getDni();
        }

        public void hablarALaClase()
        {
            this.setEstado("Hablando de algún tema");
            Console.WriteLine("Hablando de algún tema");
        }

        public void escribirEnElPizarron()
        {
            this.setEstado("Escribiendo en el pizarrón");
            Console.WriteLine("Escribiendo en el pizarrón");
        }

        public void agregar(Observador observador)
        {
            listaDeAlumnos.Add(observador);
        }
        public void quitar(Observador observador)
        {
            listaDeAlumnos.Remove(observador);
        }
        public void notificar()
        {
            foreach (Observador elemento in this.getListaDeAlumno())
            {
                elemento.actualizar(this);
            }
        }
    }
}
