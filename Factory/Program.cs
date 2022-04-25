// See https://aka.ms/new-console-template for more information

var factory = new FoodFactory();
var order = factory.OrderFood(FoodType.Burger);

order.PrepareIngridients();
order.CookFood();
order.ServeFood();
