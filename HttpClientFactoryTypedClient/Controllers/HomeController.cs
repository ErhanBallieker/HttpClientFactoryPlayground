using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HttpClientFactoryTypedClient.Models;

namespace HttpClientFactoryTypedClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly RandomUserClient _randomUserClient;

        public HomeController(RandomUserClient randomUserClient)
        {
            _randomUserClient = randomUserClient;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _randomUserClient.Client.GetAsync("?results=5");
            ViewBag.statusCode = result.StatusCode;

            var stringResult = await _randomUserClient.GetStringContentAsync();

            //var contentLength = await _randomUserClient.GetStringDataLength();

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
