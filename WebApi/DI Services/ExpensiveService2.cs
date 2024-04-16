public class ExpensiveService2 : IExpensiveService2
{
    public void DoExpensiveWork()
    {
        // Simulate some expensive operation
        Console.WriteLine("Performing expensive work2...");
    }

    public void DoExpensiveWork(string message)
    {
        Console.WriteLine("Performing expensive work2... with message : {0}", message);
    }
}