using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Entrer du texte :");
        var input = Console.ReadLine();
        var inputMaj = ConvertToUpper(input);
        Console.WriteLine(inputMaj);
    }

    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}
