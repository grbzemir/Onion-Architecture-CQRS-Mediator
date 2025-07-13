using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.UserLayoutWebUIViewComponents
{
	public class _UserLayoutWebUIHeroComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
