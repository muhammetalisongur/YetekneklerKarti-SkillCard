using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Profile;

namespace Portfolio_Mvc.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile

        ProfilManager profileManager = new ProfilManager(new EfProfilDal());

        Context context = new Context();

        public ActionResult Index()
        {

            var profilevalues = profileManager.GetList();
            return View(profilevalues);
        }
        [HttpGet]
        public ActionResult AddProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProfile(Profil profile)
        {
            ProfileValidator profileValidator = new ProfileValidator();
            ValidationResult validationResult = profileValidator.Validate(profile);
            if (validationResult.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    string fileName = Path.GetFileName(Request.Files[0].FileName);
                    string path = "~/Images/" + fileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    profile.Image = "/Images/" + fileName;
                    profileManager.ProfilAdd(profile);
                    return RedirectToAction("Index");
                }
                return HttpNotFound();

            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditProfile(int id)
        {
            var profilevalues = profileManager.GetByID(id);
            return View(profilevalues);

        }


        [HttpPost]
        public ActionResult EditProfile(Profil profile)
        {
            ProfileValidator profileValidator = new ProfileValidator();
            ValidationResult validationResults = profileValidator.Validate(profile);
            if (validationResults.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    string fileName = Path.GetFileName(Request.Files[0].FileName);

                    string path = "~/Images/" + fileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    profile.Image = "/Images/" + fileName;
                    profileManager.ProfilUpdate(profile);
                    return RedirectToAction("Index");
                }


                return HttpNotFound();

            }
            else
            {
                foreach (var item in validationResults.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }

            return HttpNotFound();


        }
        public ActionResult DeleteProfile(int id)
        {
            var profileValues = profileManager.GetByID(id);
            profileManager.ProfilDelete(profileValues);
            return RedirectToAction("Index");
        }




    }
}