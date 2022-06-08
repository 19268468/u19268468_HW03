using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u19268468_HW03.Controllers
{
    public class AboutMeController : Controller
    {
        // GET: AboutMe
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "My Profile";

            return View();
        }
    }
}