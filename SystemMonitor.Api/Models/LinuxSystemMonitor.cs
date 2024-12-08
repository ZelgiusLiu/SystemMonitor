namespace SystemMonitor.Api.Models
{
    public sealed class LinuxSystemMonitor : SystemMonitorBase
    {
        public LinuxSystemMonitor(DateTime startupUtcTime) : base(startupUtcTime)
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