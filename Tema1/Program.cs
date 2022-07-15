using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recibe nombre por consola y lo muestra
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);

            //Coge hora de sistema y la muestra
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine(datetime);
        }
    }

}
