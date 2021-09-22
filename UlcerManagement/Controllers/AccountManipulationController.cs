using Models.DAO;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UlcerManagement.Code;
using UlcerManagement.Common;

namespace UlcerManagement.Controllers
{
    public class AccountManipulationController : Controller
    {
        // GET: AccountManipulation
        public ActionResult Index()
        {
            Debug.WriteLine("########### Vo view without parameter ##############");
            return View();
        }
        [HttpGet]
        public ActionResult Index(int addedType, int adddedBy)
        {
            Debug.WriteLine("########### addedType ############## : " + addedType.ToString());
            ViewBag.addedType = addedType;
            ViewBag.adddingID = adddedBy;
            return View();
        }

        [HttpPost]
        public ActionResult Create(ACCOUNT acc)
        {
            SessionHelper sh = new SessionHelper();
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();

                int id = dao.Insert(acc);
                if (id > 0)
                {
                    if (sh.SessionDirectionCheck(CommonConstants.DOCTOR_GROUP))
                    {
                        return RedirectToAction("index", "ThreadListing", new { area = "Doctor" });
                    }
                    else
                        return RedirectToAction("Index", "AccountDisplay");
                }
                else
                {
                    ModelState.AddModelError("", CommonError.INSERT_ERROR);
                }
            }
            
            return View("Index");
        }
    }
}