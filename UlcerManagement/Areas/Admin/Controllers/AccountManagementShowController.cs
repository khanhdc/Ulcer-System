using Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UlcerManagement.Code;
using UlcerManagement.Common;

namespace UlcerManagement.Areas.Admin.Controllers
{
    public class AccountManagementShowController : Controller
    {
        // GET: Admin/AccountManagementShow
        public ActionResult Index()
        {
            // Check group login
            SessionHelper sh = new SessionHelper();
            int[] accManList = { CommonConstants.ADMIN_GROUP};


            if (sh.SessionDirectionCheck(accManList))
            {
                var iplAccount = new UserDAO();
                var model = iplAccount.ShowAllAccountAdmin();
                return View(model);
            }
            else
                return RedirectToAction("Index", "PageNotFound", new { area = "" });
            // End checking group login
        }
    }
}