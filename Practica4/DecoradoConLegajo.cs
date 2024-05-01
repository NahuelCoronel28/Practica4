using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class DecoradoConLegajo : DecoradorAlumno
    {
        IAlumno alu;
        public DecoradoConLegajo(IAlumno a):base(a)
        {
            this.alu = a;
        }
        public IAlumno getAlumno()
        {
            return base.getAlumno();
        }
        public override string mostrarCalificacion()
        {
            string resultado = base.mostrarCalificacion();
            resultado += "(" + alu.getLegajo() + ")";
            return resultado;
        }
    }
}
