using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            /************************************
             *  Ejercicio 1
             *  Recibe  datos de una persona y genera un mensaje,
             *  usa una variable para cada dato y otra para el mensaje
             *  
             *  ***********************************/
            string nombre;
            string edad;
            string mensaje;
            Console.WriteLine("Hola usuario.\nCómo te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine("Cuantos años tienes?");
            edad = Console.ReadLine();
            mensaje = "Hola "+nombre+", no aparentas "+edad+" años!!";
            Console.WriteLine(mensaje);

            /***********************************
             Ejercicio 3

             Determina los operadores para verificar las siguientes condiciones:
             Un número es mayor o igual a 18
             Un char es ‘a’
             Se cumplen dos conciones a la vez (ambas verdaderas)
             Se cumple una de dos condiciones a la vez (una true y otra false)

            ************************************/

            char a = 'a';

            Console.WriteLine("Operador mayor o igual a. Es 19 mayor o igual que 18? " + (19 >= 18));
            Console.WriteLine("Operador 'a' es char. Es la variable a un char? " + (a.GetType() == typeof(char)));
            Console.WriteLine("Operador se cumplen dos condiciones a la vez. 1<3 Y 4>2?" + ((1 < 3) && (4 > 2)));
            Console.WriteLine("Operador se cumple una de dos condiciones. 1<3 O 4>2?" + ((1 < 3) || (4 > 2)));

        }
        /*************************************
            * 
            *  Ejercicio 2
            *  Usando los tipos de variables más adecuados, describe los objetos siguientes:
               Coche: puertas, ruedas, marca, ITV vigente
               Mesa: peso, largo, material, color
           *
           ***************************************/

        class Coche
        {
            int puertas;
            int ruedas;
            string marca;
            bool itvVigente;
        }

        class Mesa
        {
            float peso;
            float largo;
            string material;
            string color;
        }
    }
}
