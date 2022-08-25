using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 10 - calculate saving");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);
            mes++;
            // mes += 1;
            // mes = mes + 1;
        }

        Console.WriteLine("Clique Enter para fechar.");
        Console.ReadLine();
    }
}



