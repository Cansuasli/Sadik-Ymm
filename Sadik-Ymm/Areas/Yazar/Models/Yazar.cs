using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Sadik_Ymm.Areas.Yazar.Models
{
    public class Yazar : Base
    {
        [Required(ErrorMessage = "Ad zorunludur")]
        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad zorunludur")]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "E-posta zorunludur")]
        [EmailAddress(ErrorMessage = "Lütfen uygun bir e-posta adresi giriniz")]
        [Display(Name = "Eposta")]
        public string Eposta { get; set; }

        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalı")]
        [Compare("SifreTekrar", ErrorMessage = "Şifreler uyuşmuyor")]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }

        [NotMapped]
        [Display(Name = "Şifre(Tekrar)")]
        public string SifreTekrar { get; set; }

        public virtual List<Makale> Makaleler { get; set; }
    }
}