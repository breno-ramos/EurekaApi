using System.Data.Entity.ModelConfiguration;
using Eureka.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eureka.Infra.Persistence.Maps
{
    public class BranchMap : EntityTypeConfiguration<Branch>
    {
        public BranchMap()
        {
            ToTable("Branch");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Status)
                .IsRequired();
        }
    }
}
