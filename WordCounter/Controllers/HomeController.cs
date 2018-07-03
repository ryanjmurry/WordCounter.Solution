using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter(Request.Query["target-word", Request.Query["search-phrase"]]);
            return View(cdList);
            newRepeatCounter.Matches();
            return View(newRepeatCounter);
        }
    }
}
