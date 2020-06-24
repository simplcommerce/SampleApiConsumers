using Microsoft.AspNetCore.Mvc;
using SampleApiConsumer.Services;
using System.Threading.Tasks;

namespace SampleApiConsumer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryApiClient _categoryApiClient;

        public HomeController(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var categories = await _categoryApiClient.GetCategories();
                return View(categories);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
