using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Models_Dress_Up
{
    public class RelationMapper
    {
        public static void Mapper(ModelBuilder modelBuilder)
        {

            /* Vendor MemberShip*/
            modelBuilder.Entity<VendorMemberShip>()
                .HasOne(vm => vm.Vendor)
                .WithMany(vm => vm.VendorMemberShips)
                .HasForeignKey(vm => vm.VendorID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<VendorMemberShip>()
               .HasOne(vm => vm.MemberShip)
               .WithMany(vm => vm.VendorMemberShips)
               .HasForeignKey(vm => vm.MemberShipID)
               .OnDelete(DeleteBehavior.Cascade);

            /*Clothes Category */
            modelBuilder.Entity<Clothes>()
                .HasOne(c => c.Category)
                .WithMany(cat => cat.Clothes).HasForeignKey(c => c.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);
            /*Order OrderItem*/
            modelBuilder.Entity<OrderItem>()
                .HasOne(i => i.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(i => i.OrderID)
                .OnDelete(DeleteBehavior.Cascade);

            /*Order User*/
            modelBuilder.Entity<Order>()
                .HasOne(o=>o.User)
                .WithMany(u=>u.Orders)
                .HasForeignKey(o=>o.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            /*OrderItem Clothes*/
            modelBuilder.Entity<OrderItem>()
                .HasOne(i => i.Clothes)
                .WithMany(c => c.OrderItems)
                .HasForeignKey(i => i.ClothesID)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
