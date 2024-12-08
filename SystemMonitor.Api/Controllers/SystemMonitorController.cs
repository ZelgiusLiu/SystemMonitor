using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SystemMonitor.Api.Models;

namespace SystemMonitor.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SystemMonitorController : ControllerBase
    {
        readonly ILogger logger;
        readonly ISystemMonitor systemMonitor;

        public SystemMonitorController(ILogger<SystemMonitorController> logger, ISystemMonitor systemMonitor)
        {
            this.logger = logger;
            this.systemMonitor = systemMonitor;
        }

        [HttpGet]
        public IActionResult GetInformation()
        {
            return Ok(SystemMonitorInfo.Create(systemMonitor));
        }
    }
}