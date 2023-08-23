using System;

namespace String_Methods
{
    class Program
    {
        static void Main()
        {
            string originalString = "Hello, World!";
            Console.WriteLine("Original String: " + originalString);

            // Length of the string
            int length = originalString.Length;
            Console.WriteLine("Length: " + length);

            // Convert to uppercase and lowercase
            string uppercase = originalString.ToUpper();
            string lowercase = originalString.ToLower();
            Console.WriteLine("Uppercase: " + uppercase);
            Console.WriteLine("Lowercase: " + lowercase);

            // Substring
            string substring = originalString.Substring(0, 5);
            Console.WriteLine("Substring: " + substring);

            // Concatenation
            string anotherString = " Welcome to C#!";
            string concatenatedString = originalString + anotherString;
            Console.WriteLine("Concatenation: " + concatenatedString);

            // IndexOf
            int indexOfComma = originalString.IndexOf(',');
            Console.WriteLine("Index of ',': " + indexOfComma);

            // Replace
            string replacedString = originalString.Replace("Hello", "Hi");
            Console.WriteLine("Replace: " + replacedString);

            // Split
            string sentence = "This is a sample sentence.";
            string[] words = sentence.Split(' ');
            Console.WriteLine("Split:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Trim
            string stringWithWhitespace = "   Trim me   ";
            string trimmedString = stringWithWhitespace.Trim();
            Console.WriteLine("Trimmed: " + trimmedString);

            // StartsWith and EndsWith
            bool startsWithHello = originalString.StartsWith("Hello");
            bool endsWithWorld = originalString.EndsWith("World!");
            Console.WriteLine("Starts with 'Hello': " + startsWithHello);
            Console.WriteLine("Ends with 'World!': " + endsWithWorld);

            // Contains
            bool containsWorld = originalString.Contains("World");
            Console.WriteLine("Contains 'World': " + containsWorld);

            // Compare
            int compareResult = String.Compare(originalString, "hello, world!", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Compare Result: " + compareResult);

            // Remove
            string stringWithoutComma = originalString.Remove(5, 1);
            Console.WriteLine("Remove: " + stringWithoutComma);

            // PadLeft and PadRight
            string paddedString = originalString.PadLeft(15, '*');
            Console.WriteLine("PadLeft: " + paddedString);
            paddedString = originalString.PadRight(15, '*');
            Console.WriteLine("PadRight: " + paddedString);
        }
    }
}
