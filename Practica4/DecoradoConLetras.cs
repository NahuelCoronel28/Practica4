using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class DecoradoConLetras : DecoradorAlumno
    {
        IAlumno alu;
        public DecoradoConLetras(IAlumno a) : base(a)
        {
            this.alu = a;
        }
        public IAlumno getAlumno()
        {
            return base.getAlumno();
        }
        public override string mostrarCalificacion()
        {
            string[] enLetras = new string[] {"CERO", "UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ"};
            string resultado = base.mostrarCalificacion();
            resultado += "(" + enLetras[alu.getCalificacion()] + ")";
            return resultado;
        }
    }
}
