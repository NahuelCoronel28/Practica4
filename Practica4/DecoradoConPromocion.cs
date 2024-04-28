using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class DecoradoConPromocion : DecoradorAlumno
    {
        IAlumno alu;
        public DecoradoConPromocion(IAlumno a) : base(a)
        {
            this.alu = a;
        }
        public override string mostrarCalificacion()
        {
            if (this.alu.getCalificacion() >= 7)
            {
                string resultado = base.mostrarCalificacion();
                resultado += "(PROMOCION)";
                return resultado;
            }
            if (this.alu.getCalificacion() > 7 && this.alu.getCalificacion() < 4)
            {
                string resultado = base.mostrarCalificacion();
                resultado += "(APROBADO)";
                return resultado;
            }
            else
            {
                string resultado = base.mostrarCalificacion();
                resultado += "(DESAPROBADO)";
                return resultado;
            }
        }
    }
}
