//Escreva um programa que receba n valores do usuário e em seguida ordene os valores em ordem ascendente.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos valores você deseja inserir? ");
        int n = int.Parse(Console.ReadLine());
        int[] valores = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(valores);
        Console.WriteLine("Valores em ordem ascendente:");
        foreach (int valor in valores)
        {
            Console.WriteLine(valor);
        }
    }
}
