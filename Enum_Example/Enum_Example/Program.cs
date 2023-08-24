namespace Enum_Example
{
    // Define an enum named DaysOfWeek
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable 'today' of type DaysOfWeek and set it to Wednesday
            DaysOfWeek today = DaysOfWeek.Wednesday;

            // Display the value of 'today'
            Console.WriteLine("Today is: " + today);

            // Use a switch statement to determine if it's a weekend or weekday
            switch (today)
            {
                case DaysOfWeek.Sunday:
                case DaysOfWeek.Saturday:
                    Console.WriteLine("It's a weekend!");
                    break;
                default:
                    Console.WriteLine("It's a weekday.");
                    break;
            }
        }
    }
}