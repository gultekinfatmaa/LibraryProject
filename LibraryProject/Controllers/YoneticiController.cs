using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yazlab2_1.Models;
using yazlab2_1.Models.EntitiyFramework;

namespace yazlab2_1.Controllers
{
    [Authorize]
    public class YoneticiController : Controller
    {
        LibraryDbEntities db = new LibraryDbEntities();

        [Route("Yonetici/kitapEkle/")]
        [HttpGet]
        public ActionResult kitapEkle()
        {
            return View();
        }
        [Route("Yonetici/kitapEkle/")]
        [HttpPost]
        public ActionResult kitapEkle(string kitapAdi, int Isbn)
        {
            var kitap = new Kitaplar();

            kitap.Kitap_Adı = kitapAdi;
            kitap.ISBN = Isbn;
            db.Kitaplar.Add(kitap);
            db.SaveChanges();

            return View();
        }

        [Route("Yonetici/zamanAtla")]
        public ActionResult zamanAtla()
        {
            return View();
        }
        [Route("Yonetici/kullanicilariListele")]
        public ActionResult kullanicilariListele()
        {
            var model = db.Kullanicilar.ToList();
            return View(model);
        }
       
    }
}