using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dress_Up_Models
{
    public class FavConfiguration : IEntityTypeConfiguration<Fav>
    {
        public void Configure(EntityTypeBuilder<Fav> builder)
        {
            builder.ToTable("Fav");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(c => c.Item).HasMaxLength(500).IsRequired();
            builder.Property(c => c.Qty).IsRequired();
            builder.Property(c => c.ClotheID).IsRequired();
            builder.Property(c => c.UserID).IsRequired();

        }
    }
}
