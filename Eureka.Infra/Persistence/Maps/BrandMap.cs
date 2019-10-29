using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Eureka.Domain.Entities;

namespace Eureka.Infra.Persistence.Maps
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            ToTable("Brand");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.Status)
                .IsRequired();            
        }
    }
}
