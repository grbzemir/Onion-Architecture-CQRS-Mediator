using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
	public class _UserLayoutWebUIPreloaderComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
