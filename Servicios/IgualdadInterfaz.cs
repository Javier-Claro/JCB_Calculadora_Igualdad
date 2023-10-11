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
        /// <returns>un entero con la opción seleccionada</returns>
        public int numeroPantalla(string contador);

        /// <summary>
        /// Método que pide un número al usuario:
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public void igualdad(int num1, int num2, bool igual);

        /// <summary>
        /// Método que realiza una suma:
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public void desIgualdad(int num1, int num2, bool desIgual);
    }
}
