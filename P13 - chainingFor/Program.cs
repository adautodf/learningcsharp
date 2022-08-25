using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 13 - echaining For");

        /*
        *
        **
        ***
        ****
        *****
        */

        int contadorLinhas;
        int contadorColunas;
        for (contadorLinhas = 0; contadorLinhas < 5; contadorLinhas++)
        {
            // contadorColunas < 5 == contadorColunas <= contadorLinhas -> não gera a necessidade do break;
            for (contadorColunas = 0; contadorColunas < 5; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Clique Enter para fechar.");
        Console.ReadLine();
    }
}



