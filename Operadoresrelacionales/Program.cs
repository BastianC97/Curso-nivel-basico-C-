using System;


namespace Operadoresrelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Num1, Num2;
            bool Operaciones;

            Num1 = 10;
            Num2 = 12;
            Operaciones = (Num1 != Num2);

            Console.WriteLine("Num1 es distinto que Num2? "+ Operaciones);
            Console.ReadKey();
           
        }
    }
}
