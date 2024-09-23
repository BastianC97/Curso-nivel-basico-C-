using System;


namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[Filas, Columnas]
            string[,] Persona = new string[3, 2];

            Persona[0, 0] = "Bastian";
            Persona[0, 1] = "Caceres";

            Persona[1, 0] = "Claudio";
            Persona[1, 1] = "Caceres";

            Persona[2, 0] = "Jorge";
            Persona[2, 1] = "Pizarro";

            for (int a = 0; a < 3; a++) 
            {
                Console.WriteLine("Persona [" + a + "] = " + Persona[a, 0] +" "+ Persona[a,1]);
                
            }


            //Console.WriteLine("El valor de la matriz persona [2,0] = " + Persona[2, 0]); esto es para identificar un dato especifico de la matriz
            Console.ReadKey();
        }
    }
}
