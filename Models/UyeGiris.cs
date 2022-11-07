using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models
{
    public class UyeGiris
    {
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAd { get; set; }
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

    }
}