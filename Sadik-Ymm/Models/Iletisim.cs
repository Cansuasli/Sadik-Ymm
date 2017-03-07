using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sadik_Ymm.Models
{
    public class Iletisim : Base
    {
        [Required(ErrorMessage = "Lütfen isim ve soyisminizi giriniz")]
        [Display(Name = "İsim Soyisim")]
        public string IsimSoyisim { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz")]
        [Display(Name = "Telefon")]
        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz")]
        [EmailAddress(ErrorMessage = "Lütfen uygun bir e-posta adresi giriniz")]
        [Display(Name = "E-posta")]
        public string Eposta { get; set; }

        [Required(ErrorMessage = "Lütfen bir konu giriniz")]
        [Display(Name = "Konu")]
        public string Konu { get; set; }

        [Required(ErrorMessage = "Lütfen bir mesaj giriniz")]
        [Display(Name = "Mesaj")]
        public string Mesaj { get; set; }
    }
}