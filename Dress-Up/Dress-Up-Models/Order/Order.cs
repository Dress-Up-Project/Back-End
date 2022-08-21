using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class Order
    {
        public int ID { get; set; }
        public string? UserID { get; set; }
        public User? User { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<OrderItem>? OrderItems { get; set; }

    }
}
