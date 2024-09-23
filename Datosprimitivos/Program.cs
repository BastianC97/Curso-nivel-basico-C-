using System;


namespace Datosprimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            double sueldo;
            bool casado;


            Console.Write("¿Cual es tu nombre?: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa tu sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Casado?: ");
            casado = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Tu nombre es " + nombre + " y tu edad es " + edad);
            Console.WriteLine("Tu sueldo es "+ sueldo+ " y la consulta de casado es "+ casado);

            Console.ReadKey();
            
        }
    }
}
