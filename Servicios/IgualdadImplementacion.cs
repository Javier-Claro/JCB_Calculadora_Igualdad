using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Igualdad.Servicios
{
    internal class IgualdadImplementacion : IgualdadInterfaz
    {

        //El string "contador", nos servirá para cuando lo escribamos por pantalla, nos sea más facil el distinguir el primer número del segundo:
        public string numeroPantalla(string contador)
        {
            Console.Write("\n\tIndique el {0} número para realizar la opreación: ", contador);
            string expresion = Console.ReadLine();
            return expresion;
        }

        public void igualdad(string expr1, string expr2, bool igual)
        {

            if (expr1 == expr2) 
            {
                igual = true; 
            } else
            {
                igual = false;
            }

            Console.WriteLine("\n\t[INFO] - Resultado de la igualdad: {0}.", igual);
        }

        public void desIgualdad(string expr1, string expr2, bool desIgual)
        {
            if (expr1 != expr2)
            {
                desIgual = true;
            }
            else
            {
                desIgual = false;
            }

            Console.WriteLine("\n\t[INFO] - Resultado de la desigualdad: {0}.", desIgual);
        }
    }
}
