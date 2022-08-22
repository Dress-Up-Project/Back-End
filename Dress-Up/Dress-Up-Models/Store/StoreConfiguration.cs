using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dress_Up_Models
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
       public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("Store");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(s => s.NameAr).HasMaxLength(500).IsRequired();
            builder.Property(s => s.NameEn).HasMaxLength(500).IsRequired();
            builder.Property(s => s.ImageUrl).IsRequired();
            builder.Property(s => s.OpenTime).IsRequired();
            builder.Property(s => s.CloseTime).IsRequired();
            builder.Property(s => s.Location).HasMaxLength(500).IsRequired();
            builder.Property(s => s.RegisterDate).HasDefaultValue(DateTime.Now);
            builder.Property(s => s.VendorID).IsRequired();





        }
    }
}
