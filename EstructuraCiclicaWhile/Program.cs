using System;


namespace EstructuraCiclicaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correlativo;
            correlativo = 0;
            Console.WriteLine("La tabla #5");

            while (correlativo<=12) 
            {
                Console.WriteLine("5 x " + correlativo + " = " + (5 * correlativo));
                correlativo++;
            }
            Console.ReadKey();
        }   
    }
}
