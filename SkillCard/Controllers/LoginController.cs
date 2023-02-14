using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Portfolio_Mvc.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context context = new Context();
            var adminUserInfo = context.Admins.FirstOrDefault(x => x.AdminMail == p.AdminMail && x.AdminPassword == p.AdminPassword);
            if (adminUserInfo != null)
            {

                FormsAuthentication.SetAuthCookie(adminUserInfo.AdminMail, false);

                Session["AdminMail"] = adminUserInfo.AdminMail;
                return RedirectToAction("Index", "Profil");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}