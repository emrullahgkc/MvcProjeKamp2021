using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);
            if (result.IsValid)
            {
                cm.CategoryAdd(category);
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

        public ActionResult CategoryDelete(int id)
        {

            var kontrol = cm.GetByID(id);
            cm.CategoryDelete(kontrol);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {
            var categoryValue = cm.GetByID(id);
          
            return View(categoryValue);
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }

    }
}