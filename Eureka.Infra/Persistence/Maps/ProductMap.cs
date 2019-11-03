using Eureka.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace Eureka.Infra.Persistence.Maps
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");

            Property(x => x.Name)
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.Description)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.Price).IsRequired();

            Property(x => x.Status);
            Property(x => x.CreationDate);
            Property(x => x.EndDate);

            HasMany(x => x.Images);
            HasMany(x => x.Categories);

            HasRequired(x => x.Brand);
            HasRequired(x => x.Model);
        }
    }
}
