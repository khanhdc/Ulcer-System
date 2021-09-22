using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UlcerManagement.Code;
using UlcerManagement.Common;

namespace UlcerManagement.Areas.Doctor.Controllers
{
    public class ImageListManagementController : Controller
    {
        // GET: Doctor/ImageListManagement
        public ActionResult Index()
        {
            // Check group login
            SessionHelper sh = new SessionHelper();
            if (sh.SessionDirectionCheck(CommonConstants.DOCTOR_GROUP))
            {
                return View();
            }
            else
                return RedirectToAction("Index", "PageNotFound", new { area = "" });
            // End checking group login
        }
    }
}