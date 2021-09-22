using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using UlcerManagement.Code;
using UlcerManagement.Common;
using Models.DAO;

namespace UlcerManagement.Areas.Doctor.Controllers
{
    public class ThreadListingController : Controller
    {
        // GET: Doctor/DoctorRecord
        public ActionResult Index()
        {
            // Check group login
            SessionHelper sh = new SessionHelper();

            UserSession session = new UserSession();
            session = (UserSession)System.Web.HttpContext.Current.Session["loginSession"];

            if (sh.SessionDirectionCheck(CommonConstants.DOCTOR_GROUP)){
                var dao = new UserDAO();
                var model = dao.PatientListAll(session.userID);
                return View(model);
            }
            else
                return RedirectToAction("Index", "PageNotFound", new { area = "" });
            // End checking group login
        }
    }
}