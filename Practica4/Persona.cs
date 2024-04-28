using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Persona : Comparable
    {
        string nombre;
        int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int getDni()
        {
            return dni;
        }

        public virtual bool sosIgual(Comparable c)
        {
            return this.getDni() == ((Persona)c).getDni();
        }
        public virtual bool sosMenor(Comparable c)
        {
            return this.getDni() < ((Persona)c).getDni();
        }
        public virtual bool sosMayor(Comparable c)
        {
            return this.getDni() > ((Persona)c).getDni();
        }

        public override string ToString()
        {
            return "Nombre: " + this.getNombre() + " ; DNI: " + this.getDni().ToString();
        }
    }
}
