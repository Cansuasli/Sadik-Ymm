using Sadik_Ymm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sadik_Ymm.Controllers
{
    public class IletisimController : Controller
    {
        private IletisimEntities _iletisimDb;

        public IletisimEntities iletisimDb
        {
            get
            {
                if (_iletisimDb == null)
                {
                    _iletisimDb = new IletisimEntities();
                }
                return _iletisimDb;
            }
        }
        // GET: Iletisim
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Iletisim iletisim)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                iletisimDb.Iletisim.Add(iletisim);
                iletisimDb.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("kayıt hatalı", ex.Message);
                return View();
            }
            finally
            {
                if (iletisimDb != null)
                {
                    ((IDisposable)iletisimDb).Dispose();
                }
            }
            return RedirectToAction("Index");
        }
    }
}