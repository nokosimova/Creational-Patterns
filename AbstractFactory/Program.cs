IMachineFactory factory1 = new HighBudjetMachine();
IMachineFactory factory2 = new LowBudjetMachine();

ComputerShop shop1 = new ComputerShop(factory1);
ComputerShop shop2 = new ComputerShop(factory2);

Console.WriteLine("------SHOP 1-------");
shop1.AssembleMachine();
Console.WriteLine("-------------------");
Console.WriteLine();

Console.WriteLine("------SHOP 2-------");
shop2.AssembleMachine();
Console.WriteLine("-------------------");
