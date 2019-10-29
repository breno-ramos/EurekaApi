using Eureka.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eureka.Infra.Persistence.Maps
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CompanyName)
                .HasMaxLength(80)
                .IsRequired();

            Property(x => x.CustomerName.FirstName)
                .HasMaxLength(40)
                .IsRequired();

            Property(x => x.CustomerName.LastName)
                .HasMaxLength(40)
                .IsRequired();

            Property(x => x.Document.DocumentValue)
                .HasMaxLength(14)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Password)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Logo)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Status)
                .IsRequired();

            HasRequired(x => x.Branch);

            HasRequired(x => x.Subscription);

            HasRequired(x => x.Address);
        }
    }
}
