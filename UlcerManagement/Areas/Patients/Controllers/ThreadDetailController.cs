using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UlcerManagement.Code;
using UlcerManagement.Common;

namespace UlcerManagement.Areas.Patients.Controllers
{
    public class ThreadDetailController : Controller
    {
        // GET: Patients/ThreadDetail
        public ActionResult Index()
        {
            // Check group login
            SessionHelper sh = new SessionHelper();
            if (sh.SessionDirectionCheck(CommonConstants.PATIENT_GROUP))
            {
                return View();
            }
            else
                return RedirectToAction("Index", "PageNotFound", new { area = "" });
        }
    }
}