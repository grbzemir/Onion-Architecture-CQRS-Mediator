using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
	public class _UserLayoutWebUIFooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
