using System;

namespace Simple_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Type Descriptions
            string[] typeDescriptions = {
                "byte: 8-bit unsigned integer",
                "sbyte: 8-bit signed integer",
                "short: 16-bit signed integer",
                "ushort: 16-bit unsigned integer",
                "int: 32-bit signed integer",
                "uint: 32-bit unsigned integer",
                "long: 64-bit signed integer",
                "ulong: 64-bit unsigned integer",
                "float: 32-bit single-precision floating-point number",
                "double: 64-bit double-precision floating-point number",
                "decimal: 128-bit decimal type",
                "char: 16-bit Unicode character",
                "bool: Boolean (true or false)",
                "string: Sequence of characters"
            };

            // Values for Simple Types
            byte myByte = 255;
            sbyte mySByte = -128;
            short myShort = 32767;
            ushort myUShort = 65535;
            int myInt = 2147483647;
            uint myUInt = 4294967295;
            long myLong = 9223372036854775807;
            ulong myULong = 18446744073709551615;
            float myFloat = 3.14f;
            double myDouble = 3.14159265358979;
            decimal myDecimal = 12345.6789m;
            char myChar = 'A';
            bool myBool = true;
            string myString = "Hello, C#!";

            // Display Simple Type Descriptions and Values
            Console.WriteLine("Simple Types and Their Values:");
            Console.WriteLine("===============================");
            for (int i = 0; i < typeDescriptions.Length; i++)
            {
                Console.WriteLine(typeDescriptions[i]);
            }

            Console.WriteLine("\nValues:");
            Console.WriteLine($"byte: {myByte}");
            Console.WriteLine($"sbyte: {mySByte}");
            Console.WriteLine($"short: {myShort}");
            Console.WriteLine($"ushort: {myUShort}");
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine($"uint: {myUInt}");
            Console.WriteLine($"long: {myLong}");
            Console.WriteLine($"ulong: {myULong}");
            Console.WriteLine($"float: {myFloat}");
            Console.WriteLine($"double: {myDouble}");
            Console.WriteLine($"decimal: {myDecimal}");
            Console.WriteLine($"char: {myChar}");
            Console.WriteLine($"bool: {myBool}");
            Console.WriteLine($"string: {myString}");
        }
    }
}
