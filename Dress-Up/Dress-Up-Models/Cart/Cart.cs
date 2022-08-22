using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models_Dress_Up;

namespace Dress_Up_Models
{
   public class Cart
    {
        public int ID { get; set; }
        public string? Item { get; set; }
        public int Qty { get; set; }
        public int ClotheID { get; set; }
        public string UserID { get; set; }
        public virtual Clothes? Clothes { get; set; }
        public virtual User? User { get; set; }

    }
}
