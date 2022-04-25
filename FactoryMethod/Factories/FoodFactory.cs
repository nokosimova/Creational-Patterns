public abstract class FoodFactory
{
    protected IFood Food;
    protected abstract void CreateFood();

    public void PrepareIngridients()
    {
        if (Food == null) CreateFood();
        Food.PrepareIngridients();
    }
    public void CookFood()
    {
        if (Food == null) CreateFood();
        Food.CookFood();
    }
    public void ServeFood()
    {
        if (Food == null) CreateFood();
        Food.ServeFood();
    }
}