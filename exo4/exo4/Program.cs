using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static List<char> alphabet = new List<char>
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    public static void Main()
    {
        AlgoTest(MyNameIs);
        Console.ReadLine();
    }

    public static string MyNameIs(string name)
    {
        var result = "";
        foreach (char c in name)
        {
            char cmin = char.ToLower(c);
            int index = alphabet.FindIndex(a => a == cmin);
            result += index;
        }
        return result;
        // myNameIs("Ahmed") should return  '071243'
        // myNameIs("Dorlean") return 31417114013
        // myNameIs("a") return  0
        // myNameIs("Sandrine") return 180133178134


    }

    public static void AlgoTest(Func<string, string> func)
    {
        if (func("AB") == "01")
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}