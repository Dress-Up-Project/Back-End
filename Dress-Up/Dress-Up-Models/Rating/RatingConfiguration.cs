using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dress_Up_Models
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Rating");
            builder.HasKey(r => r.ID);
            builder.Property(r => r.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(r => r.Comment).HasMaxLength(500).IsRequired();
            builder.Property(r => r.ClotheID).IsRequired();
            builder.Property(r => r.UserID).IsRequired();
        }
    }
}
