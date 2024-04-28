using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class ColeccionMultiple : Coleccionable
    {
        Pila pila_ejemplo;
        Cola cola_ejemplo;
        public ColeccionMultiple(Pila pila_ejemplo, Cola cola_ejemplo)
        {
            this.pila_ejemplo = pila_ejemplo;
            this.cola_ejemplo = cola_ejemplo;
        }
        public int cuantos()
        {
            int resultado1 = this.pila_ejemplo.cuantos();
            int resultado2 = this.cola_ejemplo.cuantos();
            return resultado1 + resultado2;
        }
        public Comparable minimo()
        {
            Comparable minimo1 = this.pila_ejemplo.minimo();
            Comparable minimo2 = this.cola_ejemplo.minimo();
            if (minimo1.sosMenor(minimo2))
            {
                return minimo1;
            }
            return minimo2;
        }
        public Comparable maximo()
        {

            Comparable maximo1 = this.pila_ejemplo.maximo();
            Comparable maximo2 = this.cola_ejemplo.maximo();
            if (maximo1.sosMenor(maximo2))
            {
                return maximo1;
            }
            return maximo2;
        }
        public void agregar(Comparable c)
        {

        }
        public bool contiene(Comparable c)
        {
            bool resultado1 = pila_ejemplo.contiene(c);
            bool resultado2 = cola_ejemplo.contiene(c);
            if (resultado1 || resultado2 == true)
            {
                return true;
            }
            return false;
        }
    }
}
