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
        Console.WriteLine(greeting);  // Output: Hello Bishal

        // Length of string
        Console.WriteLine("Length: " + name.Length);  // Output: 6

        // Substring
        Console.WriteLine("First 3 letters: " + name.Substring(0, 3));  // Output: Bis

        // Uppercase & Lowercase
        Console.WriteLine("Uppercase: " + name.ToUpper());  // Output: BISHAL
        Console.WriteLine("Lowercase: " + name.ToLower());  // Output: bishal

        // Replace
        string replaced = name.Replace("al", "u");
        Console.WriteLine("After replace: " + replaced);  // Output: Bishu

        // Split
        string sentence = "C# is fun to learn";
        string[] words = sentence.Split(' ');
        Console.WriteLine("First word: " + words[0]);  // Output: C#

        // Searching
        Console.WriteLine("Contains 'fun'? " + sentence.Contains("fun"));  // Output: True
    }
}
