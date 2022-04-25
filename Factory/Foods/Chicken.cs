public class Chicken : IFood
{
     public void CookFood()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("-----Cooking process:---------");
        Console.WriteLine("Fry chicken in oil ...");
        Thread.Sleep(20);
        Console.WriteLine("Chicken is ready!");
        Console.WriteLine("------------------------------");
    }

    public void PrepareIngridients()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("-----Prearing process:--------");
        Console.WriteLine("Put chicken in msrinade for 1 hour ...");
        Thread.Sleep(20);
        Console.WriteLine("Products are ready ...");
        Console.WriteLine("------------------------------");
    }

    public void ServeFood()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("------Serving process:--------");
        Console.WriteLine("Put chiken on the dish and cut...");
        Thread.Sleep(20);
        Console.WriteLine("Say: bon appetit! ...");
        Console.WriteLine("------------------------------");
    }
}