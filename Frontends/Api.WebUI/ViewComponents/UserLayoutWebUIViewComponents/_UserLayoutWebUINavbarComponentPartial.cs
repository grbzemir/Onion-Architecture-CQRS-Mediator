using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
	public class _UserLayoutWebUINavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
