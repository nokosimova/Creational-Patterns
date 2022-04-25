public class BurgerFactory : FoodFactory
{
    protected override void CreateFood()
    {
        Food = new Burger();
    }
}