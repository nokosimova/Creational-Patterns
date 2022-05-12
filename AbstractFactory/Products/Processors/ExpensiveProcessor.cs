public class ExpensiveProcessor : IProcessor
{
    public void PerformOperation()
    {
        Console.WriteLine("Operation will perform quickly!");
    }
}