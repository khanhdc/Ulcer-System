using Models.DAO;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UlcerManagement.Common;

namespace UlcerManagement.Controllers
{
    public class ProfileEditorController : Controller
    {
        // GET: ProfileEditor
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ViewProfile()
        {
            string userName = Request.Params["username"].ToString();
            ACCOUNT acc = null;
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                acc = dao.ShowPatientInfor(userName); 
            }
            return View(acc);
        }

        public ActionResult DeleteProfile()
        {
            string _userName = Request.Params["username"].ToString();
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();

                bool result = dao.DeletePatient(_userName);
                if (result)
                {
                    return RedirectToAction("Index", "ThreadListing", new { area = "Doctor" });
                }
                else
                {
                    ModelState.AddModelError("", CommonError.DELETE_ERROR);
                }
            }
            return RedirectToAction("ViewProfile", "ProfileEditor", new { username = _userName }); // View("ViewProfile", new { username = _userName });
        }

       
    }

}