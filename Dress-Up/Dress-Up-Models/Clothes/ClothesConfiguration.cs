using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Dress_Up
{
    public class ClothesConfiguration : IEntityTypeConfiguration<Clothes>
    {
        public void Configure(EntityTypeBuilder<Clothes> builder)
        {
            builder.ToTable("Clothes");
            builder.HasKey(c=>c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(c => c.NameAr).HasMaxLength(250).IsRequired();
            builder.Property(c => c.NameEn).HasMaxLength(250).IsRequired();
            builder.Property(c => c.Price).IsRequired();
            builder.Property(c => c.ImageUrl).IsRequired();
            builder.Property(c => c.RegisterDate).HasDefaultValue(DateTime.Now);

        }
    }
}
