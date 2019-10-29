using System.Data.Entity.ModelConfiguration;
using Eureka.Domain.Entities;

namespace Eureka.Infra.Persistence.Maps
{
    public class ServiceMap : EntityTypeConfiguration<Service>
    {
        public ServiceMap()
        {
            ToTable("Service");

            Property(x => x.Title)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.Phone)
                .HasMaxLength(12)
                .IsRequired();

            Property(x => x.Description)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.Site)
                .HasMaxLength(120);

            HasMany(x => x.Pictures);
        }
    }
}
