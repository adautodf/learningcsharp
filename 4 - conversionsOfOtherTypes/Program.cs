using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine(salarioInteiro);

        // o long é uma variável de 64 bits;

        long idade = 13000000000;

        Console.WriteLine(idade);

        // o int é um tipo de variável que suporta valores até 16 bits;

        short quantidadeProdutos = 150;

        Console.WriteLine(quantidadeProdutos);

        float altura = 1.80f;

        Console.WriteLine(altura);

        Console.WriteLine("Tecle Enter para fechar.");
        Console.ReadLine();
    }
}



