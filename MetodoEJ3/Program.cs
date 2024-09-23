using System;
using System.Security.Cryptography;



namespace MetodoEJ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double PagoxDia;
            int Dias;            

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Cuanto te pagan ppor dia trabajado?: ");
            PagoxDia = double.Parse(Console.ReadLine());

            Console.Write("Cuantos dias trabajaste?: ");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por los dias trabajados es: " + CalcularTotal(PagoxDia, Dias));

            Console.ReadKey();

        }
        //Metodo para obtener el total de dinero ganado por trabajo
        static double CalcularTotal(double P1, int P2)
        {
            double Total;
            Total = (P1 * P2);
            return Total;
        }
    }
     
}
