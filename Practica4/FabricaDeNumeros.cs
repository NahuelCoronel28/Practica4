using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica4
{
    internal class FabricaDeNumeros : FabricaDeComparables
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();
        public override Comparable crearAleatorio()
        {
            int numero_auxiliar = lector.numeroPorTeclado();
            return new Numero(generador.numeroAleatorio(numero_auxiliar));
        }
        public override Comparable crearPorTeclado()
        {
            return new Numero(lector.numeroPorTeclado());
        }
    }
}
