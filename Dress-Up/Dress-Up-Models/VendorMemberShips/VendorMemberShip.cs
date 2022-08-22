using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class VendorMemberShip
    {
        public int VendorID { get; set; }
        public int MemberShipID { get; set; }
        public int NumberOfOrders { get; set; }
        public bool IsValid { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual MemberShip? MemberShip { get; set; }
    }
}
