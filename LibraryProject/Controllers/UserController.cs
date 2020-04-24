using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using yazlab2_1.Models.EntitiyFramework;

namespace yazlab2_1.Controllers
{
    public class UserController : Controller
    {
        LibraryDbEntities db = new LibraryDbEntities();

        // GET: Kullanici
        [Route("Kullanici/kitapAra")]
        public ActionResult Search(int? isbn,string kitapAdi)
        {
            if (isbn != null)
            {
                var model = db.Kitaplar.Where(s => s.ISBN==isbn).ToList();
                return View(model);
            }
            else if(kitapAdi!=null)
            {
                var model = db.Kitaplar.Where(s => s.Kitap_Adı == kitapAdi).ToList();
                return View(model);
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        //[Route("Kullanici/kitapAl")]
        public ActionResult kitapAl(int? isbn)
        {
            
            
            var model = db.Kitaplar.ToList();
            //var aa = FormsAuthentication.GetAuthCookie(userName)
            Kullanicilar usersInDb = db.Kullanicilar.FirstOrDefault(x => x.isim == User.Identity.Name);
            if (isbn != null)
            {
                usersInDb.kitap = isbn;
                db.SaveChanges();
                return View("Search");
            }
            else
            {
                //db.SaveChanges();
                return View(model);
            }
            
        }
        [Authorize]
       // [Route("Kullanici/kitapVer")]
        public ActionResult kitapVer(int? isbn)
        {
            var model = db.Kitaplar.ToList();
            Kullanicilar usersInDb = db.Kullanicilar.FirstOrDefault(x => x.isim == User.Identity.Name);
            if (isbn != null)
            {
                usersInDb.kitap = null;
                db.SaveChanges();
                return View("Search");
            }
            else
            {
                return View(model);
            }
            
        }
    }
}