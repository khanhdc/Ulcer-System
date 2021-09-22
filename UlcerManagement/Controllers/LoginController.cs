using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UlcerManagement.Code;
using UlcerManagement.Models;


namespace UlcerManagement.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {            
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("index", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            //try
            //{
            var result = new AccountModel().Login(model.userName, model.passWord);
            if (result !=null && ModelState.IsValid)
            {
                Debug.WriteLine("My debug string here" + result.ToString());
                SessionHelper.SetSession(new UserSession() 
                {
                    userName = result.USERNAME, 
                    groupID = int.Parse(result.GROUP_ID.ToString()), 
                    addedBy= int.Parse(result.ADDED_BY.ToString()), 
                    userID=result.ID,
                    fullName = result.FULL_NAME,
                    profileImage = result.PROFILE_IMAGE
                });
                if (result.GROUP_ID == 0)
                    return RedirectToAction("Index", "Admin/AccountManagementShow", result.GROUP_ID);
                else
                    if (result.GROUP_ID == 1)
                    return RedirectToAction("Index", "Doctor/ThreadListing", result.GROUP_ID);
                else
                        if (result.GROUP_ID == 2)
                    return RedirectToAction("Index", "Doctor/ThreadListing", result.GROUP_ID);
                else
                            if (result.GROUP_ID == 3)
                    return RedirectToAction("Index", "Patients/ThreadListing", result.GROUP_ID);
            }
            else
            {
                ModelState.AddModelError("", "Wrong username or password!");
            }
            //}
            //catch (Exception)
            //{

            //    ModelState.AddModelError("", "Wrong username or password!");
            //}

            
            return View(model);
        }
    }
}