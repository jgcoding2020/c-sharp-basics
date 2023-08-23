using System;

namespace Math_Methods
{
    class Program
    {
        static void Main()
        {
            double number1 = 10.5;
            double number2 = 5.3;

            // Math.Abs - Absolute value
            double absResult = Math.Abs(-10.5);
            Console.WriteLine("Absolute Value: " + absResult);

            // Math.Sqrt - Square root
            double sqrtResult = Math.Sqrt(number1);
            Console.WriteLine("Square Root: " + sqrtResult);

            // Math.Pow - Power
            double powerResult = Math.Pow(number1, 2);
            Console.WriteLine("Power: " + powerResult);

            // Math.Exp - Exponential
            double expResult = Math.Exp(number1);
            Console.WriteLine("Exponential: " + expResult);

            // Math.Log - Natural logarithm
            double logResult = Math.Log(number1);
            Console.WriteLine("Natural Logarithm: " + logResult);

            // Math.Log10 - Base 10 logarithm
            double log10Result = Math.Log10(number1);
            Console.WriteLine("Base 10 Logarithm: " + log10Result);

            // Math.Floor - Round down to the nearest integer
            double floorResult = Math.Floor(number1);
            Console.WriteLine("Floor: " + floorResult);

            // Math.Ceiling - Round up to the nearest integer
            double ceilingResult = Math.Ceiling(number1);
            Console.WriteLine("Ceiling: " + ceilingResult);

            // Math.Round - Round to the nearest integer
            double roundResult = Math.Round(number1);
            Console.WriteLine("Round: " + roundResult);

            // Math.Min - Minimum of two numbers
            double minResult = Math.Min(number1, number2);
            Console.WriteLine("Minimum: " + minResult);

            // Math.Max - Maximum of two numbers
            double maxResult = Math.Max(number1, number2);
            Console.WriteLine("Maximum: " + maxResult);

            // Math.PI - Value of pi (π)
            double piValue = Math.PI;
            Console.WriteLine("Value of Pi: " + piValue);

            // Math.E - Value of Euler's number (e)
            double eValue = Math.E;
            Console.WriteLine("Value of Euler's Number: " + eValue);
        }
    }

}
