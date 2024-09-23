using System;


namespace EstructuraCiclicaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Numero = 0;

            do
            {
                Console.WriteLine("El valor de la variable Números es: " + Numero);
                //Numero = Numero + 1;(cualquiera de las dos formas es valida, pero la no comentada es la mas moderna)
                Numero++;
            } while (Numero<=10);
            Console.ReadKey();
        }
    }
}
