using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Scopes;

namespace Eureka.Domain.Entities
{
    public class Branch : Entity
    {
        public Branch(string description)
        {
            Description = description;
            Status = EStatusType.Active;

            this.ValidDescription();
            this.ValidStatus();
        }

        public string Description { get; private set; }
        public EStatusType Status { get; private set; }

        public void ActivateBranch() => Status = EStatusType.Active;
        public void DisableBranch() => Status = EStatusType.Inactive;
    }
}
