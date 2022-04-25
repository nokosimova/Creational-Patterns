public class Pizza : IFood
{
    public void CookFood()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("-----Cooking process:---------");
        Console.WriteLine("Cut vegetables and meat ...");
        Thread.Sleep(20);
        Console.WriteLine("Put pizza on heater for 20 min ...");
        Thread.Sleep(20);
        Console.WriteLine("Pizza is ready! ...");
        Console.WriteLine("------------------------------");
    }

    public void PrepareIngridients()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("-----Prearing process:--------");
        Console.WriteLine("Preparing pastry, meat, pasta ...");
        Thread.Sleep(20);
        Console.WriteLine("Washing vegerables ...");
        Thread.Sleep(20);
        Console.WriteLine("Products are ready ...");
        Console.WriteLine("------------------------------");
    }

    public void ServeFood()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("------Serving process:--------");
        Console.WriteLine("Put pizza on the dish...");
        Thread.Sleep(20);
        Console.WriteLine("Say: bon appetit! ...");
        Console.WriteLine("------------------------------");
    }
}