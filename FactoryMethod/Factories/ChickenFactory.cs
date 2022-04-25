public class ChickenFactory : FoodFactory
{
    protected override void CreateFood()
    {
        Food = new Chicken();
    }

}