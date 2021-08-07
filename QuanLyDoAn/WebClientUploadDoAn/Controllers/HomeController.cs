using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClientUploadDoAn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session == null)
                return RedirectToAction("login");
            ViewBag.Session = Session;
            return View(new DBStore.DbAcess().GetListDoAn());
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
    }
}