using Calculadora_Igualdad.Servicios;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Aritmetica
{
    /// <summary>
    /// Clase Principal de la aplicación
    /// </summary>
    class Program
    {
        static void Main(String[] args)
        {
            MenuInterfaz menu = new MenuImplementacion();
            IgualdadInterfaz igualdad = new IgualdadImplementacion();

            int num1, num2, opcionMenu;
            bool respuerta = true;

            do
            {
                opcionMenu = menu.mostrarMenu();

                switch (opcionMenu)
                {
                    case 1:

                        break;

                    case 2:
                        num1 = igualdad.numeroPantalla("primer");
                        num2 = igualdad.numeroPantalla("segundo");
                        Console.Clear();

                        igualdad.igualdad(num1, num2, respuerta);
                        break;

                    case 3:
                        num1 = igualdad.numeroPantalla("primer");
                        num2 = igualdad.numeroPantalla("segundo");
                        Console.Clear();

                        igualdad.desIgualdad(num1, num2, respuerta);
                        break;

                }
            } while (opcionMenu != 1);
        }
    }
}