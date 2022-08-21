﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dress_Up_Models
{
    public class Clothes
    {
        public int ID { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public float Price { get; set; }
        public string? Details { get; set; }
        public int SizeNum { get; set; }
        public string? Size { get; set; }
        public bool Gender { get; set; }
        public string? Color { get; set; }
        public string? ImageUrl { get; set; }

        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryID { get; set; }

        //public Category Category {get;set;} 
    }
}
