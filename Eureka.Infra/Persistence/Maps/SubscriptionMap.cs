using Eureka.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Eureka.Infra.Persistence.Maps
{
    public class SubscriptionMap : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionMap()
        {
            ToTable("Subscription");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CreateIn)
                .IsRequired();

            Property(x => x.ExpiresIn);

            Property(x => x.Status)
                .IsRequired();

            Property(x => x.Type)
                .IsRequired();

            HasRequired(x => x.Plan);
        }
    }
}
