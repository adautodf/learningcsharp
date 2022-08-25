using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 12 - long-term investment");

        double investmentFactor = 1.005;
        double investment = 1000;

        int anos;
        int mes;
        for (anos = 1; anos <= 5; anos++)
        {
            for (mes = 1; mes <= 12; mes++)
            {
                investment *= investmentFactor;
            }
            investmentFactor += 0.001;
        }

        Console.WriteLine("Depois de 5 anos, você terá R$ " + investment);

        Console.WriteLine("Clique Enter para fechar.");
        Console.ReadLine();
    }
}



