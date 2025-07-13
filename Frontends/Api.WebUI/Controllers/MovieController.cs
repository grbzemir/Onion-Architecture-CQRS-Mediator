using Api.Dto.Dtos.MovieDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Api.WebUI.Controllers
{
	public class MovieController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public MovieController(IHttpClientFactory httpClientFactory)
        {
			_httpClientFactory = httpClientFactory;

		}
        public async Task<IActionResult> MovieList()
		{
			ViewBag.v1 = "Film Listesi";
			ViewBag.v2 = "Anasayfa";
			ViewBag.v2 = "Tüm Filmler";

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7220/api/Movies");

			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
