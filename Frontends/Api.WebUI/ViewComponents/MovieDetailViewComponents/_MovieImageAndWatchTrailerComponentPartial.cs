using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.MovieDetailViewComponents
{
	public class _MovieImageAndWatchTrailerComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
