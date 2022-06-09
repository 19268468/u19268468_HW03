using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u19268468_HW03.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Video";

            return View();
        }
    }
}