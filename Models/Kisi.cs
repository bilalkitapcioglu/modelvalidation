using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ModelValidation.Models
{
    public class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        
        public string Soyad { get; set; }
        [Required]
        [DisplayName("TC Kimlik Numarası")]
        [MinLength(11, ErrorMessage =  "TC Kimlik numarası 11 karakter olmalıdır")]
        [MaxLength(11, ErrorMessage = "TC Kimlik numarası 11 karakter olmalıdır")]
        public string TCKimlikNo {get; set;}
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DogumTarih { get; set; }
       

    }

}