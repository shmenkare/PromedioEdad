using System;
using System.Collections.Generic;
using System.Text;

namespace PromedioEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            float promed = 0.0f, edadPers = 0.0f,edMayor = 0.0f, edMenor = 0.0f, edad1=15, edad2=5, edad3=45, edad4=60, edad5= 20; 
            int numPers = 0, n = 1;

            Console.WriteLine("Promedie las edades de estas personas y diga cual es la mayoy y la menor");
            Console.WriteLine();
            Console.WriteLine(" Persona 1 tiene {0} años", edad1);
            Console.WriteLine(" Persona 1 tiene {0} años", edad2);
            Console.WriteLine(" Persona 1 tiene {0} años", edad3);
            Console.WriteLine(" Persona 1 tiene {0} años", edad4);
            Console.WriteLine(" Persona 1 tiene {0} años", edad5);
            Console.WriteLine();

            promed = edad1 + edad2 + edad3 + edad4 + edad5 / 2;

            Console.WriteLine("El promedio de edades es {0}", promed);

            Console.ReadKey();

        }
    }
}
