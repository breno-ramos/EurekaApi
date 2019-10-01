using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;

namespace Eureka.Domain.Entities
{
    public class Category : Entity
    {
        public Category(string name)
        {
            Name = name;
            Status = EStatusType.Active;

            this.ValidName();
        }

        public string Name { get; private set; }
        public EStatusType Status { get; private set; }
    }
}
