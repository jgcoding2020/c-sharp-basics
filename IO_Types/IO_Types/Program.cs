class Program
{
    static void Main()
    {
        // Console Input
        Console.Write("Enter your name: ");

        // Would cause warning of possible non-nullable type
        //string name = Console.ReadLine();

        // Makes the variable nullable
        //string? name = Console.ReadLine();

        // Handles null exception
        string name = Console.ReadLine() ?? "DefaultName";

        Console.WriteLine($"Hello, {name}!");

        // Console Output
        Console.WriteLine("Console Output:");
        Console.WriteLine("This is a sample console output.");
        Console.WriteLine();

        // File Writing
        string fileName = "sample.txt";
        string fileContent = "This is a sample text file content.";

        // Write to a file using File.WriteAllText
        File.WriteAllText(fileName, fileContent);
        Console.WriteLine($"File '{fileName}' has been written with content.");

        // File Reading
        Console.WriteLine("File Reading:");
        string readContent = File.ReadAllText(fileName);
        Console.WriteLine($"File Content: {readContent}");

        // StreamWriter for File Writing
        string fileName2 = "sample2.txt";
        using (StreamWriter writer = new StreamWriter(fileName2))
        {
            writer.WriteLine("Line 1: This is the first line.");
            writer.WriteLine("Line 2: This is the second line.");
        }
        Console.WriteLine($"File '{fileName2}' has been written using StreamWriter.");

        // StreamReader for File Reading
        Console.WriteLine("File Reading with StreamReader:");
        using (StreamReader reader = new StreamReader(fileName2))
        {
            //string line;
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // Directory Operations
        string directoryName = "SampleDirectory";
        Directory.CreateDirectory(directoryName);
        Console.WriteLine($"Directory '{directoryName}' has been created.");

        // File Operations within a Directory
        string filePathInDirectory = Path.Combine(directoryName, "sampleInDirectory.txt");
        File.WriteAllText(filePathInDirectory, "Content in the directory file.");
        Console.WriteLine($"File '{filePathInDirectory}' has been written within '{directoryName}'.");

        // Cleanup: Delete created files and directory
        File.Delete(fileName);
        File.Delete(fileName2);
        File.Delete(filePathInDirectory);
        Directory.Delete(directoryName);
        Console.WriteLine("Cleanup: Deleted created files and directory.");
    }
}
