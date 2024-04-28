using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class IterableCola : Iterable
    {
        int indice;
        Cola cola;
        public IterableCola(Cola auxCola)
        {
            this.cola = auxCola;
            indice = 0;
        }

        public void primero()
        {
            indice = 0;
        }
        public void siguiente()
        {
            indice++;
        }
        public bool fin()
        {
            return indice == cola.cuantos();
        }
        public Comparable actual()
        {
            return cola.Elementos_cola()[indice];
        }
    }
}
