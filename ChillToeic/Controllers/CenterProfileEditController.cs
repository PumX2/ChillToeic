using Microsoft.AspNetCore.Mvc;

namespace ChillToeic.Controllers
{
    public class HomeCenterController : Controller
    {
        public IActionResult HomeCenter()
        {
            return View();
        }
    }
}
