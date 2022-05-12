public class ComputerShop
{
    private readonly IMachineFactory _category;
    public ComputerShop(IMachineFactory category)
    {
        _category = category;
    }

    public void AssembleMachine()
    {
        IProcessor processor = _category.GetRam();
        IMonitor monitor = _category.GetMonitor();
        IHardDisk hdd = _category.GetHardDisk();

        processor.PerformOperation();
        hdd.StoreData();
        monitor.DisplayImage();
    }
}