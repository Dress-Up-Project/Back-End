using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dress_Up_Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Models_Dress_Up
{
    public class User 
    {
        public string? ID { get; set; }
        public string? NameEN { get; set; }
        public string? NameAR { get; set; }
        public string? Image { get; set; }
        public string? Adress { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDelete { get; set; }
        public virtual List<Order>? Orders { get; set; }
        public virtual List<Rating>? Ratings { get; set; }
        public virtual List<Fav> Favs { get; set; }
        public virtual List<Cart> Carts { get; set; }



    }
}
