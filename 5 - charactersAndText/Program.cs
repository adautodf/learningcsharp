using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running the project 5 - Characters and Text");

        // character
        char primeiraLetra = 'a';

        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char)61;

        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char)(primeiraLetra + 1);

        Console.WriteLine(primeiraLetra);

        string titulo = ("Estou codando em " + 2022 + ":");
        string cursosProgramacao =
@"- .NET
- Java
- JavaScript";

        Console.WriteLine(titulo);
        Console.WriteLine(cursosProgramacao);


        Console.ReadLine();
    }
}



