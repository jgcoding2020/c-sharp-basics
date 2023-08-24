class Program
{

    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Using a lambda expression to filter even numbers
        List<int> evenNumbers = numbers.FindAll(num => num % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (int num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Using a lambda expression to perform square operation
        List<int> squaredNumbers = numbers.ConvertAll(num => num * num);

        Console.WriteLine("Squared Numbers:");
        foreach (int num in squaredNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
