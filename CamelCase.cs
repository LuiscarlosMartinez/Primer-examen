using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas_1y2
{
    public class CamelCase
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Por favor ingrese la palabra en camelCase a evaluar");
        //    string input = Console.ReadLine();
        //    int cuenta = calculate(input);
        //    Console.WriteLine("La cantidad de palabras representadas es: {0}", cuenta);
        //    Console.ReadKey();
        //}

        /*
        El método calculate recibe el string que el usuario digita. Luego, con un for,
        se recorre caracter por caracter, identificando con un if si el caracter es una
        letra en mayúscula. Cuando esa condición se cumple, el contador suma 1. El
        contador se inició en 1, ya que la primera palabra del string es en minúscula.
        Finalmente, el método devuelve la cuenta que lleva el contador.
*/
        public static int calculate (string palabra)
        {
            int cuenta = 1;
            for (int i = 0; i < palabra.Length; i++)
            {
                if (char.IsUpper(palabra[i]))
                {
                    cuenta++;
                }
            }
            return cuenta;
        }
    }
}
