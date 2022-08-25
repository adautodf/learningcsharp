using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 7 - conditional");

        int idadeJoao = 16;
        int quantidadePessoas = 1;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("João possui mais de 18 anos, ele está liberado para entrar.");
        }
        else
        {
            if (quantidadePessoas >= 2)
            {
                Console.WriteLine("João é menor de idade, mas está acompanhado. Pode entrar.");
            }
            else
            {
                Console.WriteLine("João possui menos de 18 anos, ele não está liberado para entrar.");
            }
        }

        Console.WriteLine("Clique Enter para fechar.");
        Console.ReadLine();
    }
}



