using System;

namespace RobertoCobeña3A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su número entero:");
            int tam = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tam; i++)
            {
                Console.Write(" *");
            }
            Console.Write("\n");
            for (int j = 2; j < tam; j++)
            {
                Console.Write(" *");
                for (int i = 2; i < tam; i++)
                {
                    Console.Write("  ");
                }
                Console.Write(" * \n");
            }
            for (int i = 1; i <= tam; i++)
            {
                Console.Write(" *");
            }
        }
    }
    }
