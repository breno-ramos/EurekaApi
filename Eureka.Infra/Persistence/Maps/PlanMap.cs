using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Eureka.Domain.Entities;

namespace Eureka.Infra.Persistence.Maps
{
    public class PlanMap : EntityTypeConfiguration<Plan>
    {
        public PlanMap()
        {
            ToTable("Plan");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.Description)
                .HasMaxLength(120)
                .IsRequired();

            Property(x => x.Price)
                .IsRequired();

            Property(x => x.CreateDate)
                .IsRequired();

            Property(x => x.Status)
                .IsRequired();
        }
    }
}
