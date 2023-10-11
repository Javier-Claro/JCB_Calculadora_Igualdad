using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Igualdad.Servicios
{
    internal interface IgualdadInterfaz
    {
        /// <summary>
        /// Método que pide un número al usuario:
        /// </summary>
        /// <returns>un string con la expresión escrita</returns>
        public string numeroPantalla(string contador);

        /// <summary>
        /// Método que mira si son iguales:
        /// </summary>
        public void igualdad(string expr1, string expr2, bool igual);

        /// <summary>
        /// Método que mira si son iguales:
        /// </summary>
        public void desIgualdad(string expr1, string expr2, bool desIgual);
    }
}
