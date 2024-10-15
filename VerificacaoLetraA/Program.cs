using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string entrada = Console.ReadLine();
        int quantidade = ContarLetraA(entrada);

        Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) aparece {quantidade} vez(es) na string.");
    }

    static int ContarLetraA(string str)
    {
        int quantidade = 0;
        foreach (char c in str)
        {
            if (char.ToLower(c) == 'a')
            {
                quantidade++;
            }
        }
        return quantidade;
    }
}
