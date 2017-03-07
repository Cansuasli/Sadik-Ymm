using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sadik_Ymm.Models
{
    public class Base
    {
        [Key]
        public int ID { get; set; }

        public bool IsRead { get; set; }

        public bool IsRemoved { get; set; }
    }
}