public class HighBudjetMachine : IMachineFactory
{
    IHardDisk IMachineFactory.GetHardDisk()
    {
        return new ExpensiveHDD();
    }

    IMonitor IMachineFactory.GetMonitor()
    {
        return new HighPerformanceMonitor();        
    }

    IProcessor IMachineFactory.GetRam()
    {
        return new ExpensiveProcessor();
    }
}
