using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSiteMapProvider.Web.Mvc.Filters;

namespace Example1Snippet.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

      
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [SiteMapTitle("Item2")]
        public ActionResult Page(int Id)
        {
            var title = "Page " + Id.ToString();
            var model = new Tuple<int, string>(Id, title);

            return View(model);
        }
    }
}