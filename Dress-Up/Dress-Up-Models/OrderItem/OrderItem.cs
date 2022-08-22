using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ClothesID { get; set; }
        public int Qty { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Clothes? Clothes { get; set; }
    }
}
