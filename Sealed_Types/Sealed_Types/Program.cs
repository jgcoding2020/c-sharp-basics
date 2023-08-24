// Base class that cannot be further subclassed due to the 'sealed' keyword
public sealed class SealedBase
{
    public void BaseMethod()
    {
        Console.WriteLine("Base method called");
    }
}

// Uncommenting the next line will result in a compilation error
//public class Derived : SealedBase
//{
//    public void DerivedMethod()
//    {
//        Console.WriteLine("Derived method called");
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the SealedBase class
        SealedBase sealedInstance = new SealedBase();
        sealedInstance.BaseMethod();

        // Uncommenting the next lines will result in a compilation error
        //Derived derivedInstance = new Derived();
        //derivedInstance.DerivedMethod();
    }
}