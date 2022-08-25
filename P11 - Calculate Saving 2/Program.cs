using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 11 - calculate saving 2");

        double investimento = 1000;


        int mes;
        for (mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);
        }

        Console.WriteLine("Clique Enter para fechar.");
        Console.ReadLine();
    }
}



