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
        CategoryIstatisticManager CIM = new CategoryIstatisticManager(new EfCategoryIstatisticDal()); 
        HeadingIstatisticManager HIM = new HeadingIstatisticManager(new EfHeadingIstatisticDal());
        WriterIstatisticManager WIM = new WriterIstatisticManager(new EfWriterIstatisticDal()); 
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