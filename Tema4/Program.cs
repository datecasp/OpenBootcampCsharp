using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *   TEMA 4
 *  
 * Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10

Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.

Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* *

* *

***
*
**/

namespace Tema4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //Pide un número y muestra su tabla *10
            int numTabla = 0;
            int indexTabla = 1;

            Console.WriteLine("Ejercicio 1\n");
            Console.WriteLine("Introduce un número: ");
            numTabla = Convert.ToInt32(Console.ReadLine());
            while (indexTabla <= 10)
            {
                Console.WriteLine(numTabla +" * " + indexTabla + " = " + (numTabla * indexTabla));
                indexTabla++;
            }

            //Ejercicio 2
            //Positivo o negativo
            int[] numRecibido = new int[1];
            int positivos =0, negativos =0, zeros = 0;
            
            int indexEj2=0;

            Console.WriteLine("Ejercicio 2\n");
            Console.WriteLine("Introduce un número negativo o positivo o una letra para terminar: ");
            do
            {
                try
                {
                    if (indexEj2 == 0) 
                    {
                        numRecibido[indexEj2] = Convert.ToInt32(Console.ReadLine());
                        SeparaNumeros(numRecibido[indexEj2],ref positivos,ref negativos,ref zeros);
                       
                    }
                    else
                    {
                        //Aumento el tamaño del array en 1
                        Array.Resize(ref numRecibido, numRecibido.Length + 1);
                        numRecibido[numRecibido.Length - 1] = Convert.ToInt32(Console.ReadLine());
                        SeparaNumeros((numRecibido[numRecibido.Length - 1]), ref positivos, ref negativos, ref zeros);
                    }

                }
                catch
                {
                    /*
                     * Si el valor introduceido por consola no se puede conveertir en INT32
                     * es que se ha introducido una letra
                     * salta una excepción que nos muestra el resultado de 
                     * positivos, negativos y zeros
                     * y termina el bucle
                     */
                    indexEj2 = numRecibido.Length;
                    Console.WriteLine("Resultado");
                    Console.WriteLine("Positivos : " + positivos);
                    Console.WriteLine("Negativos : " + negativos);
                    Console.WriteLine("Zeros : " + zeros);
                }

                //Sumo uno al índice para generar condición de salida
                indexEj2++;
            } while (indexEj2 <= numRecibido.Length);


            /*
             * Función para separa el valor introducido entre 
             * positivo, negativo y zero.
             * Paso por referencia los parámetros positivo, negativo y zero
             * para que se modifiquen sus valores fuera de la función
             */
            void SeparaNumeros(int numero, ref int posit, ref int negat, ref int zer)
            {
                if (numero < 0)
                {
                    negat++;
                }
                else if (numero > 0)
                {
                    posit++;
                }
                else
                {
                    zer++;
                }
            }

            /*
             * 
             * Ejercicio 3
             * 
             * Cuadrados de asteriscos
             * 
             */

            int ancho = 0, alto = 0;
            char relleno;
            bool charCorrecto = true;
            bool otraFigura = false;
            string salir = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Introduce el ancho de la figura: ");
                    try
                    {
                        ancho = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Eso no es un valor válido");
                    }
                } while (ancho <= 0);
                do
                {
                    Console.WriteLine("Introduce el alto de la figura: ");
                    try
                    {
                        alto = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Eso no es un valor válido");
                    }
                } while (alto <= 0);
                do
                {
                    Console.WriteLine("Introduce Y si quieres que este relleno y N si no: ");
                    relleno = Convert.ToChar(Console.ReadLine());
                    if (relleno.Equals('Y') || relleno.Equals('N'))
                    {
                        charCorrecto = false;
                    }
                    else
                    {
                        Console.WriteLine("Eso no es un valor válido");
                    }
                } while (charCorrecto);

                //Pintamos la figura con bucles
                for (int i = 0; i < alto; i++)
                {
                    if (relleno.Equals('Y') || i == 0 || i == alto - 1)
                    {

                        for (int j = 0; j < ancho; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        Console.Write('*');
                        for (int k = 0; k < ancho - 2; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Quieres pintar otra figuar, inserta 'Y'.");
                salir = Console.ReadLine();
                if (salir.Equals("Y"))
                {
                    otraFigura = true;
                }
                else
                {
                    otraFigura= false;
                }
            } while (otraFigura);
        }

        
    }
}
