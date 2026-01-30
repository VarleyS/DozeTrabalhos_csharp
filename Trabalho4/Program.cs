Console.WriteLine("\t\t Varley Ribeiro\n\t Conquistando os desafios em C#");

int tamanho;

Console.WriteLine("Informe o tamanho da Matrix Identidade: ");
tamanho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n\n Matrix Indetidade\n\n");

for (int i = 0; i < tamanho; i++)
{
    for (int j = 0; j < tamanho; j++)
    {
        if (i == j)
        {
            Console.Write(1);
        }
        else
        {
            Console.Write(0);
        }
    }
    Console.WriteLine("\n");
}
Console.ReadKey();