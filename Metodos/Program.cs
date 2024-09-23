using System;


namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngresoDatos();
            Console.ReadKey();
        }

        //Metodo ejemplo 1
        static void IngresoDatos() 
        {
            String Nombre;
            Console.Write("Ingresa tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + Nombre);
        }

    }
}
