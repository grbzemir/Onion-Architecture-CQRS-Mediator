using Microsoft.AspNetCore.Mvc;

namespace Api.WebUI.ViewComponents.MovieDetailViewComponents
{
	public class _MovieDetailRelatedMoviesComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
