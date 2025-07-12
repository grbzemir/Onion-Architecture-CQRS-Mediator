using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
	public class _UserLayoutWebUILoginModalComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
