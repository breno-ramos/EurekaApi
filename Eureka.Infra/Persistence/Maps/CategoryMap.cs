using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Eureka.Domain.Entities;

namespace Eureka.Infra.Persistence.Maps
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.Status)
                .IsRequired();

            HasMany(x => x.Brands)
                .WithMany(x => x.Categories);
        }
    }
}
