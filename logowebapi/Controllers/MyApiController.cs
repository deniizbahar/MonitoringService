using Microsoft.AspNetCore.Mvc;
using Serilog.Events;
using Günlük; // Günlük namespace'ini import et

namespace logowebapi
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyApiController : ControllerBase
    {
        public MyApiController()
        {
            // LoggerHelper ve LoggerService'in yapýlandýrýlmasý Program.cs'de yapýldý, bu yüzden burada tekrar yapýlandýrmaya gerek yok
        }

        [HttpGet("sum")]
        public IActionResult Sum(int x, int y)
        {
            LoggerHelper.Log(LogEventLevel.Information, $"Sum method called with parameters x: {x}, y: {y}");
            return Ok(x + y);
        }

        [HttpGet("ping")]
        public IActionResult Ping()
        {
            LoggerHelper.Log(LogEventLevel.Information, "Ping method called");
            return Ok("Pong");
        }
    }
}
