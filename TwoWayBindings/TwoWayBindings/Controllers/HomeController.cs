using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwoWayBindings.ViewModels;

namespace TwoWayBindings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Bindings(FilterViewModel filter)
        {
            if (ModelState.IsValid)
            {
                return View(filter);
            }
            return View(new FilterViewModel());
        }

        public ActionResult OtherApproach(OtherApproachViewModelV filter)
        {
            return View(filter);
        }

        public ActionResult MyApproach(TestViewModel posted)
        {
            return View(posted);
        }
    }
}