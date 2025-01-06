using Boilerplate.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Api.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(x =>  x.Id);

            builder.Property(x => x.Title).IsRequired(true).HasColumnType("VARCHAR").HasMaxLength(80);
            builder.Property(x => x.Description).IsRequired(false).HasColumnType("VARCHAR").HasMaxLength(255);
            builder.Property(x => x.UserId).IsRequired(true).HasColumnType("VARCHAR").HasMaxLength(160);
        }
    }
}
