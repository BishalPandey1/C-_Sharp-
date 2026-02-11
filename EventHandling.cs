using System;

class Program
{
    // Step 1: Declare an event
    public static event Action MyEvent;

    static void Main()
    {
        // Step 2: Subscribe to the event (attach a handler)
        MyEvent += () => Console.WriteLine("Event handled: Something happened!");

        // Step 3: Raise (trigger) the event
        Console.WriteLine("Triggering event...");
        MyEvent?.Invoke();
    }
}
