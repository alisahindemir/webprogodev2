using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniResimler()
        {
            ViewBag.Message = "Yeni Resimler";
            return View();
        }
        public ActionResult EskiResimler()
        {
            ViewBag.Message = "Eski Resimler";
            return View();
        }
        public ActionResult İletisim()
        {
            ViewBag.Message = "İletişim";
            return View();
        }
        public ActionResult UyeGiris()
        {
            ViewBag.Message = "Giris";
            return View();
        }
    }
}