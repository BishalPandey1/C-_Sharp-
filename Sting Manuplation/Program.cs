// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        string name = "Bishal";
        
        // Concatenation
        string greeting = "Hello " + name;
        Console.WriteLine(greeting); 
        // Length of string
        Console.WriteLine("Length: " + name.Length); 

        // Substring
        Console.WriteLine("First 3 letters: " + name.Substring(0, 3));  

        // Uppercase & Lowercase
        Console.WriteLine("Uppercase: " + name.ToUpper());  
        Console.WriteLine("Lowercase: " + name.ToLower());  

        // Replace
        string replaced = name.Replace("al", "u");
        Console.WriteLine("After replace: " + replaced); 

        // Split
        string sentence = "C# is fun to learn";
        string[] words = sentence.Split(' ');
        Console.WriteLine("First word: " + words[0]); 

        // Searching
        Console.WriteLine("Contains 'fun'? " + sentence.Contains("fun"));  c
    }
}
