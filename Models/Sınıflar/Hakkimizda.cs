using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace backpackProj.Models.Sınıflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Acikalama { get; set; }
    }
}