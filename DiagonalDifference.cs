using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas_1y2
{
    public class DiagonalDifference
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Por favor ingrese el arreglo a evaluar");
        //    string input = Console.ReadLine();
        //    int total = matrix(input);
        //    Console.WriteLine("El resultado es: {0}", total);
        //    Console.ReadKey();
        //}

        /* Con el método matrix se recibe el string que el usuario introdujo, y se utiliza
           el método convertirString para converirlo en un arreglo, de manera que se pueda
           recorrer y hacer las operaciones en las posiciones solicitadas.
           Luego, utilicé un for para recorrer la primera diagonal e ir sumando los números
           (previamente convertidos). Para la segunda diagonal se iba haciendo el recorrido
           pero restando cada uno.
           Al final se retorna el total de las sumas y restas.
*/
        public static int matrix(string arr)
            {
                string[,] arreglo = convertirString(arr);
                int size = arreglo.GetUpperBound(1);
                int j = 0;
                int resultado = 0;
                for (int i = 0; i <= size; i++)
                {
                    resultado += Convert.ToInt32(arreglo[i, j]);
                    j++;
                }
                for (int i = 0; i <= size; i++)
                {
                    resultado -= Convert.ToInt32(arreglo[i, j-1]);
                    j--;
                }
                return resultado;
            }

            /*
            Con el método convertirString lo que se hace es que primero se crea un arreglo
            con los números del string del usuario. Cada item del arreglo tiene una fila. Eso
            se logra al usar el método Split con el separador | de manera que ese arreglo
            es del mismo largo que la cantidad de filas y ya que es cuadrado, también de 
            columnas. Para conocer la cantidad de filas, tuve que usar un foreach que sume
            a un contador cada vez que haya un substring con el separador | . Pensé en usar
            alguna variacion del metodo Substring, pero como un número puede tener 1, 2 o
            mas caracteres, se me complicaba saber qué índice tomar.
            Al conocer ya la cantidad de filas y columnas, que son iguales, se
            inicializa el arreglo con ese dato. Luego usé un for anidado para ir cargando
            el arreglo con un número por item, usando nuevamente el metodo Split para 
            obtener número por número, aprovechando el arreglo que ya había obtenido con
            los números acomodados por filas.
            Finalmente, retorna un arreglo tipo string con un solo numero en cada posición.

    */
            public static string[,] convertirString(string input)
            {
                char delim1 = ' ';
                char delim2 = '|';
                
                string[] PorFilas = input.Split(delim2);
                int size = 0;
                foreach (var filaOcolumna in PorFilas)
                {
                    size++;
                }
                string[,] arreglo = new string[size,size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        string[] numeros = PorFilas[i].Split(delim1);
                        arreglo[i, j] = numeros[j];
                    }
                }
                return arreglo;
            }
    }


}

