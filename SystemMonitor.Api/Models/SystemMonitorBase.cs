namespace SystemMonitor.Api.Models
{
    public abstract class SystemMonitorBase : ISystemMonitor
    {
        public DateTime StartupUtcTime { get; private set; }

        #region Constructors
        protected SystemMonitorBase(DateTime startupUtcTime)
        {
            StartupUtcTime = startupUtcTime;
        }
        #endregion

        #region Public Methods
        public abstract string GetSystemDescription();
        public abstract double GetMemoryStatus();
        public abstract double GetCPUStatus();
        #endregion
    }
}