using System;


namespace MetodoEJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OperacionMatematica;
            int Noperacion;

            Console.Write("Quieres realizar la tabla de sumar o multiplicar?: ");
            OperacionMatematica = Console.ReadLine();
            Console.Write("Que numero de tabla desea que se muestre?: ");
            Noperacion = int.Parse(Console.ReadLine());

            if (OperacionMatematica == "Sumar")
            {
                Sumar(Noperacion);
            }
            else if (OperacionMatematica == "Multiplicar")
            {
                Multiplicar(Noperacion);
            }
            else
            {
                Console.WriteLine("Operacion matematica no valida");
            }
            

            Console.ReadKey();
        }

        //Metodo de la tabla de sumar
        static void Sumar(int Numero) 
        {
            for(int a=1; a<=12; a++) 
            {
                Console.WriteLine(Numero +" + "+ a +" = " + (Numero + a));
            }
        }


        //Metodo de la tabla de mutiplicar
        static void Multiplicar(int Numero) 
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " x " + a + " = " + (Numero * a));
            }

        }
    }
}
