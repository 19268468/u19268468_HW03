using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u19268468_HW03.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
           

            return View();
        }
           
        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (files != null && files.ContentLength > 0)
            {
                // extract only the filename

                var fileName = Path.GetFileName(files.FileName);

                // store the file inside ~/App_Data/uploads folder

                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);

                // The chosen default path for saving

                files.SaveAs(path);
            }
            // redirect back to the index action to show the form once again

            return RedirectToAction("Index");
        }

    }
}