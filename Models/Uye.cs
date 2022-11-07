using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [EmailAddress()]
        public string Eposta { get; set; }
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [DisplayName("Şifre Tekrarı")]
        [DataType(DataType.Password)]
        [Compare("Sifre")]
        public string Sifre2 { get; set; }
    }
}