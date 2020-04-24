using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using yazlab2_1.Models.EntitiyFramework;

namespace yazlab2_1.Controllers
{
    public class HomeController : Controller
    {
        LibraryDbEntities db = new LibraryDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanicilar kullanici)
        {
            var userInDb = db.Kullanicilar.FirstOrDefault(x => x.isim == kullanici.isim && x.password==kullanici.password);
            if (userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(userInDb.isim, false);
                return RedirectToAction("Search", "User");

            }
            else
            {
                ViewBag.Mesaj = "Geçersiz kullanıcı adı ya da şifre";
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}