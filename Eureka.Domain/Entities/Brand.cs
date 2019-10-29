using System.Collections.Generic;
using System.Linq;
using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;

namespace Eureka.Domain.Entities
{
    public class Brand : Entity
    {
        private IList<Category> _categories;

        public Brand(string name)
        {
            Name = name;
            Status = EStatusType.Active;
            _categories = new List<Category>();
        }

        public string Name { get; private set; }
        public EStatusType Status { get; private set; }
        public ICollection<Category> Categories
        {
            get
            {
                return _categories.ToArray();
            }
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }
    }
}
