using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContextExperiment.Models;
using Newtonsoft.Json;

namespace ContextExperiment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Distance()
        {
            Address address1 = new Address("804 Washington St., #2C", "Evanston", "IL", "60202");
            Address address2 = new Address("138 Abbot Avenue", "Worthington", "OH", "43085");
            
            var jsonAddress1 = JsonConvert.SerializeObject(address1);

            return Json(jsonAddress1);
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
