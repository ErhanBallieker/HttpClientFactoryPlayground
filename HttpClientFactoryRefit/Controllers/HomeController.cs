using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HttpClientFactoryRefit.Models;

namespace HttpClientFactoryRefit.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRandomUserApi _randomUserApi;
        public HomeController(IRandomUserApi randomUserApi)
        {
            _randomUserApi = randomUserApi;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _randomUserApi.GetUser("10");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
