/*Escreva um programa que usando a instrução switch e que a partir de um valor informado pelo usuário realize as seguintes conversões :
P->Polegadas para Centímetros
G -> Galão para Litros
M -> Milhas para Kilometros
Para a primeira conversão o usuário deverá informar a opção P , para a segunda deve informar G e para a terceira deve informar M.
 
Teoria
1 milha é igual a 1,609 Km ou 1609 metros ou 160934 centímetros
1 polegada é igual a 2,54 cm, ou 0,0254 metros ou 25,4 milímetros
1 galão é igual a 3,78 litros
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\t Varley Ribeiro\n\t Conquistando os desafios em C#");
        int valor;
        char escolha;
        double centimetro, litros, kilometro;

        Console.WriteLine("Informe o valor a ser convertido:");
        valor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a opção de conversão:\nP -> Polegadas para Centímetros\nG -> Galão para Litros\nM -> Milhas para Kilometros");

        escolha = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (escolha)
        {
            case 'P':
                centimetro = valor / 0.3937;
                Console.WriteLine($"{valor} polegadas são {centimetro} centímetros (cm).");
                break;
            case 'G':
                litros = valor * 3.78;
                Console.WriteLine($"{valor} galões são {litros} litros.");
                break;
            case 'M':
                kilometro = valor * 1.60;
                Console.WriteLine($"{valor} milhas são {kilometro} quilômetros.");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha P, G ou M.");
                break;
        }
        Console.ReadKey();
    }
}