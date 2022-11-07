using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelValidation.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        public ActionResult Giris()
        {
            return View();
        }
        public ActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Uye yeniuye)
        {
            bool modeldekiDegerlerDogruMu = ModelState.IsValid;
            return View();
        }
       
    }
}