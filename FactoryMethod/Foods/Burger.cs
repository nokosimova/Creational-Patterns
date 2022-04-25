public class Burger : IFood
{
     public void CookFood()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("-----Cooking process:---------");
        Console.WriteLine("Cut vegetables ...");
        Thread.Sleep(20);
        Console.WriteLine("Fry meet chop ...");
        Thread.Sleep(20);
        Console.WriteLine("Construct burger! ...");
        Thread.Sleep(20);
        Console.WriteLine("Burger is ready!");
        Console.WriteLine("------------------------------");
    }

    public void PrepareIngridients()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("-----Prearing process:--------");
        Console.WriteLine("Preparing bread, meat, sauce, vegetables ...");
        Thread.Sleep(20);
        Console.WriteLine("Beat meat ...");
        Thread.Sleep(20);
        Console.WriteLine("Products are ready ...");
        Console.WriteLine("------------------------------");
    }

    public void ServeFood()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("------Serving process:--------");
        Console.WriteLine("Put burger on the dish...");
        Thread.Sleep(20);
        Console.WriteLine("Say: bon appetit! ...");
        Console.WriteLine("------------------------------");
    }
}