using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Ex7
             Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
             In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
             */

            int number;
            Console.WriteLine("Introduceri numarul:");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Numarul este par.");
            }
            else
            {
                Console.WriteLine("Numarul este impar.");
            }
        }
    }
}
