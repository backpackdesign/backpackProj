﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace backpackProj.Models.classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string BASLIK { get; set; }
        public DateTimeOffset TARIH { get; set; }
        public string ACIKLAMA { get; set; }
        public string BLOGIMAGE { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}