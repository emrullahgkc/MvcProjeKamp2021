using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class IstatistikController : Controller
    {
        CategoryStatisticManager CIM = new CategoryStatisticManager(new EfCategoryStatisticDal()); 
        HeadingStatisticManager HIM = new HeadingStatisticManager(new EfHeadingStatisticDal());
        WriterStatisticManager WIM = new WriterStatisticManager(new EfWriterStatisticDal()); 
        public ActionResult Index()
        {

            int CategorySayisi = CIM.CategoryTotal();
            ViewBag.catSayi = CategorySayisi;
            int CatAktif = CIM.CategoryActive();
            ViewBag.catAktif = CatAktif;
           int CatPasif = CIM.CategoryPassive();
            ViewBag.catPasif = CatPasif;
            ViewBag.yazilimAd = HIM.HeadingCategoryName("Yazılım");
            ViewBag.yazilimId = HIM.HeadingCategoryId(12);
            ViewBag.harf = WIM.WriterNameFind("a");
            ViewBag.maxCat = HIM.HeadingMaxCategoryTOP() ;      
            ViewBag.catFark = CatAktif - CatPasif;
            return View();
        }
    }
}