using System;
using System.Collections.Generic;
using System.Text;

namespace PromedioEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            float promed = 0.0f,edMayor = 0.0f, edMenor = 0.0f, edad1=5, edad2=5, edad3=45, edad4=60, edad5= 20; 
            

            Console.WriteLine("Promedie las edades de estas personas y diga cual es la mayor y la menor");
            Console.WriteLine();
            Console.WriteLine(" Persona 1 tiene {0} años", edad1);
            Console.WriteLine(" Persona 1 tiene {0} años", edad2);
            Console.WriteLine(" Persona 1 tiene {0} años", edad3);
            Console.WriteLine(" Persona 1 tiene {0} años", edad4);
            Console.WriteLine(" Persona 1 tiene {0} años", edad5);
            

            promed = (edad1 + edad2 + edad3 + edad4 + edad5) / 5;
            Console.WriteLine();
            
            Console.WriteLine("El promedio de edades es {0}", promed);
            Console.WriteLine();

            if (edad1>=edad2&&edad1>=edad3&&edad1>=edad4&&edad1>=edad5)
            {
                Console.WriteLine("{0} es la edad mayor", edad1);
            }
            else if (edad2 >= edad1 && edad2 >= edad3 && edad2 >= edad4 && edad2 >= edad5)
            {
                Console.WriteLine("{0} es la edad mayor", edad2);
            }
            else if (edad3 >= edad1 && edad3 >= edad2 && edad3 >= edad4 && edad3 >= edad5)
            {
                Console.WriteLine("{0} es la edad mayor", edad3);
            }
            else if (edad4 >= edad1 && edad4 >= edad2 && edad4 >= edad3 && edad4 >= edad5)
            {
                Console.WriteLine("{0} es la edad mayor", edad4);
            }
            else if (edad5 >= edad1 && edad5 >= edad2 && edad5 >= edad3 && edad5 >= edad4)
            {
                Console.WriteLine("{0} es la edad mayor", edad5);
            }
            Console.WriteLine();

            if (edad1 <= edad2 && edad1 <= edad3 && edad1 <= edad4 && edad1 <= edad5)
            {
                Console.WriteLine("{0} es la edad menor", edad1);
            }
            else if (edad2 <= edad1 && edad2 <= edad3 && edad2 <= edad4 && edad2 <= edad5)
            {
                Console.WriteLine("{0} es la edad menor", edad2);
            }
            else if (edad3 <= edad1 && edad3 <= edad2 && edad3 <= edad4 && edad3 <= edad5)
            {
                Console.WriteLine("{0} es la edad menor", edad3);
            }
            else if (edad4 <= edad1 && edad4 <= edad2 && edad4 <= edad3 && edad4 <= edad5)
            {
                Console.WriteLine("{0} es la edad menor", edad4);
            }
            else if (edad5 <= edad1 && edad5 <= edad2 && edad5 <= edad3 && edad5 <= edad4)
            {
                Console.WriteLine("{0} es la edad menor", edad5);
            }


                Console.ReadKey();

        }
    }
}
