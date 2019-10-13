using System.Data.Entity.ModelConfiguration;
using Eureka.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eureka.Infra.Persistence.Maps
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("Address");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Number)
                .IsRequired();

            Property(x => x.Street)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.Neighborhood)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.City)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.State)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.Country)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.Complement)
                .HasMaxLength(120);
        }
    }
}
