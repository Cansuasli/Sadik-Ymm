using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sadik_Ymm.Areas.Yazar.Models
{
    public class Makale : Base
    {
        [Display(Name = "Yazarı")]
        public int YazarId { get; set; }

        [Required(ErrorMessage = "Başlık zorunludur")]
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "İçerik olması zorunludur")]
        [Display(Name = "İçerik")]
        [AllowHtml]
        public string Icerik { get; set; }

        [Display(Name = "Resim")]
        public string Resim { get; set; }

        [Required(ErrorMessage = "Sayfa adresi boş geçilemez")]
        [Display(Name = "Sayfa")]
        public string Sayfa { get; set; }

        [Required(ErrorMessage = "Seo açıklaması zorunludur")]
        [MaxLength(100, ErrorMessage = "Seo açıklaması 100 karakterden fazla olamaz")]
        [Display(Name = "Açıklama(seo)")]
        public string MetaAciklama { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime EklenmeTarihi { get; set; }

        [ForeignKey("YazarId")]
        public virtual Yazar Yazari { get; set; }
    }
}