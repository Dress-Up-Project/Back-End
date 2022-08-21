using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Models_Dress_Up
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem").HasKey(o=>o.ID);
            builder.Property(o => o.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(o => o.Qty).IsRequired();
        }
    }
}
