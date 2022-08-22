using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class Category
    {
        public int ID { get; set; }
        public string? NameEN { get; set; }
        public string? NameAR { get; set; }
        public bool IsDelated { get; set; }
        public virtual List<Clothes>? Clothes { get; set; }
    }
}
