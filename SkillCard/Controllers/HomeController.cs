using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ProfilManager profileManager = new ProfilManager(new EfProfilDal());
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public ActionResult Index()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.Profiles = profileManager.GetList();
            mymodel.Skills = skillManager.GetList();
            return View(mymodel);

        }
    }
}