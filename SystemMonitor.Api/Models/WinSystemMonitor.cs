namespace SystemMonitor.Api.Models
{
    public class WinSystemMonitor : SystemMonitorBase
    {
        public WinSystemMonitor(DateTime startupUtcTime) : base(startupUtcTime)
        {
        }

        public override double GetCPUStatus()
        {
            throw new NotImplementedException();
        }

        public override double GetMemoryStatus()
        {
            throw new NotImplementedException();
        }

        public override string GetSystemDescription()
        {
            throw new NotImplementedException();
        }
    }
}