using System.Collections.Generic;
using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;
using System.Linq;

namespace Eureka.Domain.Entities
{
    public class Category : Entity
    {
        private IList<Brand> _brands;

        public Category(string name)
        {
            Name = name;
            Status = EStatusType.Active;
            _brands = new List<Brand>();

            this.ValidName();
        }

        public string Name { get; private set; }
        public EStatusType Status { get; private set; }
        public ICollection<Brand> Brands
        {
            get
            {
                return _brands.ToArray();
            }
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }
    }
}
