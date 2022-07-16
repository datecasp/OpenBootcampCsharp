using System;

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
            Console.WriteLine("Hoal usuario.\nCómo te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine("Cuantos años tienes?");
            edad = Console.ReadLine();

           
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
