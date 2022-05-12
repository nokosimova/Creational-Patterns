public interface IMachineFactory 
{
    IMonitor GetMonitor();
    IProcessor GetRam();
    IHardDisk GetHardDisk();
}