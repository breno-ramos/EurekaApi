using System;
using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;
using Eureka.Domain.Scopes;

namespace Eureka.Domain.Entities
{
    public class Plan : Entity
    {
        public Plan(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
            CreateDate = DateTime.Now;
            Status = EStatusType.Active;

            this.ValidName();
            this.ValidDescription();
            this.ValidPrice();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EStatusType Status { get; private set; }
    }
}
