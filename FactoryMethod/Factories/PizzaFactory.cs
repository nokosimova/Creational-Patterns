public class PizzaFactory : FoodFactory
{
    protected override void CreateFood()
    {
        Food = new Pizza();
    }
}