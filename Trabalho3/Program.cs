using System;

namespace Trabalho2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Varley Ribeiro\n\t Conquistando os desafios em C#\n");

            Char ch;

            int i = 1;

            do
            {
                Console.Write(i);
                Console.Write(" ");
                ch = (char)i;
                Console.WriteLine(ch);
                i++;
            } while (i <= 255);
            Console.ReadKey();
        }
    }
}