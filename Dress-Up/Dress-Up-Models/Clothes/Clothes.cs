using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dress_Up_Models;

namespace Models_Dress_Up
{
    public class Clothes
    {
        public int ID { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public string? Details { get; set; }
        public float Price { get; set; }
        public string? Color { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryID { get; set; }
        public int SizeNum { get; set; }
        public string? Size { get; set; }
        public string? StoreID { get; set; }

        public bool Gender { get; set; }

        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }

        public Category? Category { get; set; }
        public Store? Store { get; set; }

        public List<OrderItem>? OrderItems { get; set; }
        public List<Cart>? Carts { get; set; }
        public List<Fav>? Favs{ get; set; }

        public List<Rating>? Ratings { get; set; }
       



    }
}
