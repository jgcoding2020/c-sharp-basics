using System;

// Define a Person class to represent individuals.
public class Person
{
    public string Name { get; set; } // Name property of the person
    public int Age { get; set; }    // Age property of the person

    // Override the Equals method to compare two Person objects.
    public override bool Equals(object obj)
    {
        // Check if the provided object is null or not of the same type.
        if (obj == null || GetType() != obj.GetType())
        {
            return false; // Return false if the objects are not of the same type.
        }

        // Cast the provided object to a Person.
        Person other = (Person)obj;

        // Compare the Name and Age properties of the two Person objects.
        return Name == other.Name && Age == other.Age;
    }

    // Override the GetHashCode method to generate a hash code for the Person object.
    public override int GetHashCode()
    {
        // Combine the hash codes of the Name and Age properties.
        return Name.GetHashCode() ^ Age.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create three Person objects.
        Person person1 = new Person { Name = "Alice", Age = 30 };
        Person person2 = new Person { Name = "Alice", Age = 30 };
        Person person3 = new Person { Name = "Bob", Age = 25 };

        // Compare person1 and person2 using Equals method.
        bool areEqual1 = person1.Equals(person2);
        Console.WriteLine("Are person1 and person2 equal? " + areEqual1); // Should print "Are person1 and person2 equal? True"

        // Compare person1 and person3 using Equals method.
        bool areEqual2 = person1.Equals(person3);
        Console.WriteLine("Are person1 and person3 equal? " + areEqual2); // Should print "Are person1 and person3 equal? False"
    }
}
