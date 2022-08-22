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
        public int StoreID { get; set; }
        public bool Gender { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Store? Store { get; set; }
        public virtual List<OrderItem>? OrderItems { get; set; }
        public virtual List<Cart>? Carts { get; set; }
        public virtual List<Fav>? Favs{ get; set; }
        public virtual List<Rating>? Ratings { get; set; }
    }
}
