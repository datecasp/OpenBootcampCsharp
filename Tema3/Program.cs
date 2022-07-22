using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************
 * Ejercicio Tema 3 Estructuras de datos en C#
 * 
 * Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
*
********************************************************/

namespace Tema3
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cli1 = new cliente("Juan Lopez", 123456789, "calle empinada, 12", "juanlopez@ese.es", true);
            Console.WriteLine(cli1.ToString());
         } 
    } 
}

public struct cliente
{
    public cliente(string nombre, long telefono, string direccion, string email, bool nuevoCliente):this()
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.direccion = direccion; 
        this.email = email;
        this.nuevoCliente = nuevoCliente;
    }

    //Propiedades de la estructura de datos
    public string nombre;
    public long telefono;
    public string direccion;
    public string email;
    public bool nuevoCliente;

    //getters y setters
    //Nombre solo tendrá get para evitar que se pueda modificar el nombre
    //el resto tendrán get y set 
    public string Nombre { get; }
    public long Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool NuevoCliente { get; set; }

    public override string ToString()
    {
        return ("Nombre: " + nombre + "\nTeléfono: " + telefono + "\nDirección: " + direccion + "\nEmail: " + email + "\nNuevo cliente: " + nuevoCliente);

    }

}

