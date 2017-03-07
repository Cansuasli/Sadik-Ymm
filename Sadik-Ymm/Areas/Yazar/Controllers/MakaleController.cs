using Sadik_Ymm.Areas.Yazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Sadik_Ymm.Areas.Yazar.Controllers
{
    public class MakaleController : BaseController
    {

      
        public ActionResult MakaleListesi()
        {
            try
            {
                List<Makale> makaleler = new List<Makale>();
                makaleler = db.Makale
                .Include("Yazari")
                .ToList();
                return View(makaleler);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("HATA", ex.Message);
                return View();
            }
        }
               public ActionResult Ekle()
             {
                   return View();
             }

            [HttpPost]
            public ActionResult Ekle(Makale makale, HttpPostedFileBase resim)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                try
                {
                    makale.YazarId = 1;
                    makale.EklenmeTarihi = DateTime.Now;
                    db.Makale.Add(makale);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("HATA", ex.Message);
                    return View();
                }
                return RedirectToAction("MakaleListesi");
            }
            public ActionResult Duzenle(int ID)
            {
                if (ID == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Makale secilen = db.Makale.Find(ID);
                return View(secilen);
            }

            [HttpPost]
            public ActionResult Duzenle(Makale model, HttpPostedFileBase resim)
            {
                try
                {
                    Makale secilen = db.Makale.Find(model.Id);
                    secilen.Baslik = model.Baslik;  
                    secilen.MetaAciklama = model.MetaAciklama;
                    secilen.Sayfa = model.Sayfa;
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("HATA", ex.Message);
                   
                    return View();
                }
                return RedirectToAction("MakaleListesi");
            }
       
           
            public ActionResult Sil(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                try
                {
                    Makale secilen = db.Makale.Find(id);
                    db.Makale.Remove(secilen);
                    db.SaveChanges();
                    return RedirectToAction("MakaleListesi");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("HATA", ex.Message);
                    return View();
                }
            }
        }
    }
