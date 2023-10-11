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
        public int numeroPantalla(string contador)
        {
            Console.Write("\n\tIndique el {0} número para realizar la opreación: ", contador);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public void igualdad(int num1, int num2, bool igual)
        {

            if (num1 == num2) 
            {
                igual = true; 
            } else
            {
                igual = false;
            }

            Console.WriteLine("\n\t[INFO] - Resultado de la igualdad: {0}.", igual);
        }

        public void desIgualdad(int num1, int num2, bool desIgual)
        {
            if (num1 != num2)
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
