using Example1Snippet.fonts;
using Example1Snippet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example1Snippet.Controllers
{
    public class TupleTestController : Controller
    {
        // GET: TupleTest
        public ActionResult Index()
        {
            var context = new ModelContext();
            var product = context.Products.Find(1);
            var newsPosts = context.NewsPosts.ToList();

            var models = new Tuple<Product, List<NewsPost>>(product, newsPosts);
            return View(models);
        }
    }
}