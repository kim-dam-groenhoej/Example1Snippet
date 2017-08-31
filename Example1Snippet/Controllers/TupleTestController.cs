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
            var products = context.Products.ToList();
            var products2 = context.Products.Where(d => d.Name == "asd").ToList();
            var newsPosts = context.NewsPosts.ToList();

            var models = new Tuple<List<Product>, List<NewsPost>, List<Product>>(products, newsPosts, products2);
            return View(models);
        }
    }
}