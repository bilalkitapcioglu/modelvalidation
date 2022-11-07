using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ModelValidation.Controllers
{
    public class KisiController : Controller
    {
        public ActionResult Yeni()
        {
            return View();
        }
       [HttpPost]
       public ActionResult Yeni(Kisi yeniKisi)
        {
            bool modeldekiDegerlerDogruMu = ModelState.IsValid;
            return View();
        }


        private static Kisi _kisi = new Kisi
        {

            Id = 1,
            Ad = "Bilal",
            Soyad = "Kitapçıoğlu",
            TCKimlikNo = "21658504528",
            DogumTarih = new DateTime(1990, 11, 05)
        };
           
        public ActionResult Duzenle()
        {
            return View(_kisi);
        }
        public ActionResult Detay()
    {
        return View(_kisi);
    }



    }
}

    