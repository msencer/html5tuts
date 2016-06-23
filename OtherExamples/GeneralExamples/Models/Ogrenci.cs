using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralExamples.Models
{
    public class Ogrenci
    {
        [Required]
        public string AdSoyad { get; set; }
        [Range(1,4)]
        public int Sinif { get; set; }
        [Range(0, 4.0)]
        public double Ortalama { get; set; }
    }
}