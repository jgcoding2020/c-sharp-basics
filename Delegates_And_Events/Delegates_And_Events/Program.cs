// Step 1: Define a delegate
// Declare a delegate named EventHandler that represents methods taking a string parameter and returning void.
public delegate void EventHandler(string message);

// Step 2: Define a class that contains the event
public class Publisher
{
    // Declare an event named RaiseCustomEvent of type EventHandler.
    public event EventHandler RaiseCustomEvent;

    // Method to perform an action and raise the event.
    public void DoSomething()
    {
        Console.WriteLine("Something is being done...");

        // Call the OnRaiseCustomEvent method to raise the event with the message "Action completed."
        OnRaiseCustomEvent("Action completed.");
    }

    // Virtual method to raise the event. Protected so that it can only be accessed by derived classes.
    protected virtual void OnRaiseCustomEvent(string message)
    {
        // Check if RaiseCustomEvent is not null (i.e., if there are subscribers), then invoke the
        // event with the message.
        RaiseCustomEvent?.Invoke(message);
    }
}

// Step 3: Define a class that subscribes to the event
public class Subscriber
{
    // Method that handles the event and displays the received message.
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Subscriber received message: {message}");
    }
}

// Step 4: Main program
class Program
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // Subscribing to the event: Add the HandleEvent method of the subscriber to the event's invocation list.
        publisher.RaiseCustomEvent += subscriber.HandleEvent;

        // Triggering the event by calling the DoSomething method of the publisher.
        publisher.DoSomething();

        // Unsubscribing from the event: Remove the HandleEvent method of the subscriber from the event's invocation list.
        publisher.RaiseCustomEvent -= subscriber.HandleEvent;

        // Triggering the event again, but the subscriber won't receive it since it's unsubscribed.
        publisher.DoSomething();
    }
}
