using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.Controllers
{
    public class UserWebUILayoutController : Controller
    {
        public IActionResult LayoutUI()
        {
            return View();
        }
    }
}
