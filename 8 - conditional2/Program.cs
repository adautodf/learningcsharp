using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 8 - conditional 2");

        int idadeJoao = 16;
        //int quantidadePessoas = 2;

        bool acompanhado = false;

        if (idadeJoao >= 18 || acompanhado == true)
        {
            Console.WriteLine("Liberado para entrar.");
        }
        else
        {
            Console.WriteLine("Não está liberado para entrar.");
        }

        Console.WriteLine("Clique Enter para fechar.");
        Console.ReadLine();
    }
}



