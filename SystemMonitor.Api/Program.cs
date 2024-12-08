
using SystemMonitor.Api.Models;

namespace SystemMonitor.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var utcNow = DateTime.UtcNow;

        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

        builder.Services.AddSingleton<ISystemMonitor>(provider => Environment.OSVersion.Platform switch
        {
            PlatformID.Win32NT => new WinSystemMonitor(utcNow),
            PlatformID.Unix => new LinuxSystemMonitor(utcNow),
            _ => throw new NotSupportedException(),
        });

        builder.Services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.ClearProviders();
            loggingBuilder.AddSimpleConsole();
        });

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
