using Microsoft.AspNetCore.Mvc;

namespace Day2_NguyenQuangThang.ViewComponents
{
    public class WelcomeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            return View("Default", name);
        }
    }
}
