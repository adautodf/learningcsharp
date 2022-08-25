using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 9 - scope");

        int idadeJoao = 18;
        bool acompanhado = false;
        string mensagemAdicional;

        if (acompanhado == true)
        {
            mensagemAdicional = "João está acompanhado";
        }
        else
        {
            mensagemAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanhado == true)
        {
            Console.WriteLine("Liberado para entrar.");
            Console.WriteLine(mensagemAdicional);
        }
        else
        {
            Console.WriteLine("Não está liberado para entrar.");
            Console.WriteLine(mensagemAdicional);
        }

        Console.WriteLine("Clique Enter para fechar.");
        Console.ReadLine();
    }
}



