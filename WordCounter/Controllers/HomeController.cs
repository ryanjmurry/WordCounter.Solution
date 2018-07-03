using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace CDLoop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CD newCD01 = new CD("Tight Knit", "Vetiver", 10);
            CD newCD02 = new CD("The Gaudy Side of Town", "Gayngs", 12);
            CD newCD03 = new CD("Scorpion", "Drake", 15);
            List<CD> cdList = new List<CD>() { newCD01, newCD02, newCD03 };
            return View(cdList);
        }
    }
}
