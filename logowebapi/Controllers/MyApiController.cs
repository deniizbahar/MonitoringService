using Microsoft.AspNetCore.Mvc;
using Serilog.Events;
using G�nl�k; // G�nl�k namespace'ini import et

namespace logowebapi
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyApiController : ControllerBase
    {
        public MyApiController()
        {
            // LoggerHelper ve LoggerService'in yap�land�r�lmas� Program.cs'de yap�ld�, bu y�zden burada tekrar yap�land�rmaya gerek yok
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
