using System;


namespace Conversiontipodedatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            //Edad = Convert.ToInt32(Console.ReadLine());
            Edad = int.Parse(Console.ReadLine());

            Console.Write("Eres casdao?: ");
            //Casado = Convert.ToBoolean(Console.ReadLine());
            Casado = bool.Parse(Console.ReadLine());

            Console.Write("Tu sueldo: ");
            //Sueldo = Convert.ToDouble(Console.ReadLine());
            Sueldo = double.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
