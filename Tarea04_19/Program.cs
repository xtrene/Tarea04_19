using System;

namespace Tarea04_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enunciado: Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 3. Utiliza el bucle que desees.

            // Asumiendo que el número ha de cumplir ambas condiciones (entre 2 y entre 3) 
            Console.WriteLine("Los números del 1 al 100 divisibles entre 2 Y 3: ");
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.Write(" " + i);
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            // Asumiendo que el número ha de cumplir alguna de las condiciones (entre 2 o entre 3) 
            Console.WriteLine("Los números del 1 al 100 divisibles entre 2 o entre 3: ");
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.Write(" " + i);
                }

            }

            Console.ReadKey();
        }
    }
}
