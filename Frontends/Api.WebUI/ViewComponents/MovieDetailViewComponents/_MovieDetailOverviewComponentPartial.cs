using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.MovieDetailViewComponents
{
	public class _MovieDetailOverviewComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			
			return View();
		}
	}
}
