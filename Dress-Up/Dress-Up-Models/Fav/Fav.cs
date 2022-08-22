using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models_Dress_Up;

namespace Dress_Up_Models
{
    public class Fav
    {
        public string? ID { get; set; }
        public string? Item { get; set; }
        public int Qty { get; set; }
        public int ClotheID { get; set; }
        public int UserID { get; set; }


        public Clothes? Clothes { get; set; }
        public User? User{ get; set; }


    }
}
