using Calculadora_Igualdad.Servicios;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Igualdad
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

            string expr1, expr2;
            int opcionMenu;
            bool respuerta = true;

            do
            {
                opcionMenu = menu.mostrarMenu();

                switch (opcionMenu)
                {
                    case 1:

                        break;

                    case 2:
                        expr1 = igualdad.numeroPantalla("primer");
                        expr2 = igualdad.numeroPantalla("segundo");
                        Console.Clear();

                        igualdad.igualdad(expr1, expr2, respuerta);
                        break;

                    case 3:
                        expr1 = igualdad.numeroPantalla("primer");
                        expr2 = igualdad.numeroPantalla("segundo");
                        Console.Clear();

                        igualdad.desIgualdad(expr1, expr2, respuerta);
                        break;
                }
            } while (opcionMenu != 1);
        }
    }
}