using System;


namespace CondicionIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            double Sueldo;

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingresa tu sueldo: ");
            Sueldo = Double.Parse(Console.ReadLine());
            // El sueldo minimo en chile son 450 mil
            // S i el sueldo es mayor a 450 mil y menor o igual a 1000, tu sueldo es aceptable
            // El sueldo ingresado es mayor a 1000, tu sueldo es elevado

            if (Sueldo <= 450)
            {
                Console.WriteLine(Nombre + ", El sueldo que tu tienes es igual o menor a el mínimo en Chile");
            }else if(Sueldo>450 && Sueldo<=1000)
            {
                Console.WriteLine(Nombre + ", Tu sueldo es rentable");
            }else if(Sueldo > 1000)
            {
                Console.WriteLine(Nombre + " , Tu sueldo es elevado");
            }
            
            //else (este else es solo si tenemos dos condiciones)
            //{
               // Console.WriteLine(Nombre + ", El sueldo que tu tienes es superior a el mínimo en Chile");
            //}

                Console.ReadKey();
        }
    }
}
