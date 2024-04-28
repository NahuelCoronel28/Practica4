using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Numero : Comparable
    {
        private int valor;
        public Numero(int valor)
        {
            this.valor = valor;
        }
        public int getValor()
        {
            return valor;
        }
        public void setValor(int Valor)
        {
            valor = Valor;
        }

        public bool sosIgual(Comparable c)
        {
            return this.getValor() == ((Numero)c).getValor();
        }
        public bool sosMenor(Comparable c)
        {
            return this.getValor() < ((Numero)c).getValor();
        }
        public bool sosMayor(Comparable c)
        {
            return this.getValor() > ((Numero)c).getValor();
        }
        public override string ToString()
        {
            return this.getValor().ToString();
        }
    }
}
