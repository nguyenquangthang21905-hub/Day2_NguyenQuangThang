using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2_NguyenQuangThang.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int nunTimes = 5)
        {
            ViewBag.Message = "Hello " + name;
            ViewData["NumTimes"] = nunTimes;
            return View();
        }

        [HttpGet("hello/profile/{name?}")]
        public IActionResult Profile(string? name)
        {
            return Content($"Hello {name ?? "guest"}! This page uses attribute routing.");
        }
    }
}
