using Sadik_Ymm.Areas.Yazar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sadik_Ymm.Areas.Yazar.Controllers
{
    public class BaseController : Controller
    {
        private MakaleVerileri _makaleDb;

        protected MakaleVerileri db
        {
            get
            {
                if (_makaleDb == null)
                {
                    _makaleDb = new MakaleVerileri();
                }
                return _makaleDb;
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}