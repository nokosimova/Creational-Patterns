public class LowBudjetMachine : IMachineFactory
{
    public IHardDisk GetHardDisk()
    {
        return new CheapHDD();
    }

    public IMonitor GetMonitor()
    {
        return new LowPerformanceMonitor();
    }

    public IProcessor GetRam()
    {
        return new CheapProcessor();
    }
}
