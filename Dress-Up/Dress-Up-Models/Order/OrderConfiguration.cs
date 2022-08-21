using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order").HasKey(o => o.ID);
            builder.Property(o => o.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(o => o.RegisterDate).HasDefaultValue(DateTime.Now);
            builder.Property(o => o.IsDeleted).HasDefaultValue(false);

        }
    }
}
