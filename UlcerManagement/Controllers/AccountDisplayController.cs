using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;
using Models.DAO;
using UlcerManagement.Common;

namespace UlcerManagement.Controllers
{
    public class AccountDisplayController : Controller
    {
        // GET: AccountManagement
        public ActionResult Index()
        {
            return View();
        }
        
    }
}