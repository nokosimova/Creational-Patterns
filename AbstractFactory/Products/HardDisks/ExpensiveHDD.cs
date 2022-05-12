public class ExpensiveHDD : IHardDisk
{
    public void StoreData()
    {
        Console.WriteLine("Data will take less time to store!");
    }
}