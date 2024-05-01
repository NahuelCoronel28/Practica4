using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class DecoradoConRecuadro : DecoradorAlumno
    {
        IAlumno alu;
        public DecoradoConRecuadro(IAlumno a) : base(a)
        {
            this.alu = a;
        }
        public IAlumno getAlumno()
        {
            return base.getAlumno();
        }
        public override string mostrarCalificacion()
        {
            string resultado = "***************************************\n" + " *        " + base.mostrarCalificacion() + "      * \n" + "***************************************";           
            return resultado;
        }
    }
}
