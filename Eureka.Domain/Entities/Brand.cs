using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;

namespace Eureka.Domain.Entities
{
    public class Brand : Entity
    {
        public Brand(string name)
        {
            Name = name;
            Status = EStatusType.Active;
        }

        public string Name { get; private set; }
        public EStatusType Status { get; private set; }
    }
}
