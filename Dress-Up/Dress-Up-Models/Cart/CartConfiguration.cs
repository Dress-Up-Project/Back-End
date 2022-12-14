using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dress_Up_Models
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(c => c.Item).HasMaxLength(500).IsRequired();
            builder.Property(c => c.Qty).IsRequired();
            builder.Property(c => c.ClotheID).IsRequired();


        }
    }
}
