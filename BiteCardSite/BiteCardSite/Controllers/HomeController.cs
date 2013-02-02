using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BiteCardSite.Models;
using BiteCardEntityModel;
namespace BiteCardSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (var categories = new DisplayContexts())
            {
                
            }
            var currentModel = new IndexPage();
            var cats = new List<string>();
            cats.Add("Birthday");
            cats.Add("Wedding");
            currentModel.Categories = cats;
            return View("Index", currentModel);
        }

    }
}
