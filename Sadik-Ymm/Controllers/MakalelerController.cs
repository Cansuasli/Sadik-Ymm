using Sadik_Ymm.Areas.Yazar.Models;
using Sadik_Ymm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Sadik_Ymm.Controllers
{
    public class MakalelerController : Controller
    {
        
        public ActionResult Index()
        {
            try
            {
                List<Makale> makaleler;
                using (MakaleVerileri db = new MakaleVerileri())
                {
                    makaleler = db.Makale
                    .Include("Yazari")
                    .OrderBy(x => Guid.NewGuid())
                    .Take(5).ToList();
                }
                return View(makaleler);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("HATA", ex.Message);
                return View();
            }
        }

        public ActionResult Goster(int ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            try
            {
                using (MakaleVerileri db = new MakaleVerileri())
                {
                  
                    Makale secilen = db.Makale.Find(ID);
                    return View(secilen);
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("HATA", ex.Message);
                return View();
            }
         }
    }
}