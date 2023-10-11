using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Igualdad.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionEntrada;

            Console.WriteLine("\n\t########################################");
            Console.WriteLine("\n\t1: Cerrar app");
            Console.WriteLine("\n\t2: Igualdad");
            Console.WriteLine("\n\t3: Desigualdad");
            Console.WriteLine("\n\t########################################");
            Console.WriteLine("\n\tSeleccione una opción:");

            opcionEntrada = Console.ReadKey(true).KeyChar - ('0');

            return opcionEntrada;
        }
    }
}
