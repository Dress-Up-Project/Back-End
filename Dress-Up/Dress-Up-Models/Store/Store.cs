using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models_Dress_Up;

namespace Dress_Up_Models
{
    public class Store
    {
        public int ID { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string? Location{ get; set; }
        public int VendorID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual List<Clothes>? Clothes { get; set; }


    }
}
