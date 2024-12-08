using System.Runtime.InteropServices;

namespace SystemMonitor.Api.Models
{
    public record class SystemMonitorInfo(HostInfo HostInfo, SystemInfo SystemInfo, string RuntimeInfo, DateTime StartupUtcTime)
    {
        public TimeSpan ServiceRunningTime { get => DateTime.UtcNow.Subtract(StartupUtcTime); }

        public static SystemMonitorInfo Create(ISystemMonitor systemMonitor) => throw new NotImplementedException();
    }

    public record class SystemInfo(string SystemName, string SystemArch, string SystemDesc)
    {
        public static SystemInfo GetSystemInfo(string systemDesc) => new(
            "",
            RuntimeInformation.OSArchitecture.ToString(),
            systemDesc);
    }
}