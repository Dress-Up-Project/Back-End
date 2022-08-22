using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dress_Up_Models;
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

            /* Store - Vendor*/
            modelBuilder.Entity<Store>()
               .HasOne(vm => vm.Vendor)
               .WithMany(vm => vm.Stores)
               .HasForeignKey(vm => vm.VendorID)
               .OnDelete(DeleteBehavior.Cascade);

            /*User - Rating */
            modelBuilder.Entity<Rating>().HasOne(r => r.User)
                .WithMany(u => u.Ratings).HasForeignKey(r => r.UserID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

             /*User - Fav */
            modelBuilder.Entity<Fav>()
               .HasOne(U => U.User)
               .WithMany(F => F.Favs)
               .HasForeignKey(U => U.UserID)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();

            /*User - Cart*/
            modelBuilder.Entity<Cart>()
               .HasOne(U => U.User)
               .WithMany(C => C.Carts)
               .HasForeignKey(U => U.UserID)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();

            /*User - Rating */
            modelBuilder.Entity<Rating>().HasOne(r => r.User)
                .WithMany(u => u.Ratings).HasForeignKey(r => r.UserID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            /*Clothes - Fav */
            modelBuilder.Entity<Fav>().HasOne(f => f.Clothes)
                .WithMany(r => r.Favs).HasForeignKey(f => f.ClotheID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            /*Clothes - Cart */
            modelBuilder.Entity<Cart>().HasOne(c => c.Clothes)
                .WithMany(r => r.Carts).HasForeignKey(f => f.ClotheID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            /*Clothes - Rating */
            modelBuilder.Entity<Rating>().HasOne(ra => ra.Clothe)
                .WithMany(r => r.Ratings).HasForeignKey(ra => ra.ClotheID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            /*Clothes - Store*/
            modelBuilder.Entity<Clothes>().HasOne(r => r.Store)
                .WithMany(c => c.Clothes).HasForeignKey(r => r.StoreID)
                .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
