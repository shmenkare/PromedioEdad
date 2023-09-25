using System;
using System.Collections.Generic;
using System.Text;

namespace PromedioEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            //V 3.0
            int i = 0, j = 0, edad = 0, edMayor = 0, edMenor = 150;
            float promed = 0.0f, sum = 0.0f;
            

            Console.WriteLine("Ingrese un numero de personas, pida y promedie las edades \nde estas personas y diga cual es la mayor y cual la menor");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());

            int [] personaEdad = new int [n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Dame una edad");
                edad = Convert.ToInt32(Console.ReadLine());
                personaEdad[i]=edad;
            }
            
            foreach(int elem in personaEdad)
            {
            //Console.Write(elem);
            sum += elem;
            }
            //Console.WriteLine(sum);
            promed = sum / n;
            Console.WriteLine("El promedio de las edades dadas es {0}",promed);
            
            foreach (int elem in personaEdad)
            {
                if(elem < edMenor)
                    edMenor = elem;
            }
            //Console.WriteLine(edMenor);
            
            Console.WriteLine("La menor de las edades es {0}", edMenor);
            
            foreach (int elem in personaEdad)
            {
                if (elem > edMayor)
                    edMayor = elem;
            }
            //Console.WriteLine(edMayor);

            Console.WriteLine("La mayor de las edades es {0}", edMayor);
            


                Console.ReadKey();

        }
    }
}
