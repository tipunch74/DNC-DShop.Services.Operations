using Microsoft.AspNetCore.Mvc;

namespace DShop.Services.Operations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get() => Ok("DShop Operations Service");
    }
}