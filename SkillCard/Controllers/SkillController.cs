using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Mvc.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill


        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public ActionResult Index()
        {

            var skillvalues = skillManager.GetList();
            return View(skillvalues);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            SkillValidator skillValidation = new SkillValidator();
            ValidationResult result = skillValidation.Validate(skill);
            if (result.IsValid)
            {
                skillManager.SkillAdd(skill);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var skillvaluess = skillManager.GetByID(id);
            return View(skillvaluess);
        }
        [HttpPost]
        public ActionResult EditSkill(Skill skill)
        {
            SkillValidator skillValidation = new SkillValidator();
            ValidationResult validationResult = skillValidation.Validate(skill);
            if (validationResult.IsValid)
            {
                skillManager.SkillUpdate(skill);
                return RedirectToAction("Index");
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
        public ActionResult DeleteSkill(int id)
        {
            var skillvalues = skillManager.GetByID(id);
            skillManager.SkillDelete(skillvalues);
            return RedirectToAction("Index");
        }
    }
}