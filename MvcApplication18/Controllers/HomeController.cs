using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLib;

namespace MvcApplication18.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new PersonRepo(Properties.Settings.Default.ConStr);
            return View(new HomePageViewModel{People = repo.GetPeople()});
        }

    }

    public class HomePageViewModel
    {
        public IEnumerable<People> People { get; set; } 
    }
}
