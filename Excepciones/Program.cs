using System;


namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            try
            {
                Console.Write("Ingresa tu edad: ");
                Edad = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: "+ex.Message);
            }

            Console.ReadKey();
        }
    }
}
