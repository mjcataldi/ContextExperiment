using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContextExperiment.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace ContextExperiment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Distance()
        {
            string origin = new Address("804 Washington St.", "Evanston", "IL", "60202").FullAddressQuery();
            string destination = new Address("138 Abbot Avenue", "Worthington", "OH", "43085").FullAddressQuery();
            string builder = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={ origin }&destinations={ destination }";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(builder);

            return Content(response.Content.ToString());
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
