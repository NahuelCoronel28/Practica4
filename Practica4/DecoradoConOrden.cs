using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class DecoradoConOrden : DecoradorAlumno
    {
        IAlumno alu;
        public DecoradoConOrden(IAlumno a) : base(a)
        {
            this.alu = a;
        }
        public IAlumno getAlumno()
        {
            return base.getAlumno();
        }
        public override string mostrarCalificacion()
        {
            int contador = 1;
            string resultado = base.mostrarCalificacion();
            resultado += contador + ")";
            contador++;
            return resultado;
        }
    }
}
