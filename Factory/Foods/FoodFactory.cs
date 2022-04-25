public class FoodFactory {
    public IFood OrderFood (FoodType type)
    {
        switch(type)
        {
            case FoodType.Pizza:
                return new Pizza();
            case FoodType.Burger:
                return new Burger();
            case FoodType.Chicken:
                return new Chicken();
            default:
                return new Pizza();
        }
    }
}