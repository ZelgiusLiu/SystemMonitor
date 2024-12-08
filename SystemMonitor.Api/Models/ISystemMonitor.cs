namespace SystemMonitor.Api.Models
{
    public interface ISystemMonitor
    {
        DateTime StartupUtcTime { get; }
        string GetSystemDescription();
        double GetMemoryStatus();
        double GetCPUStatus();
    }
}