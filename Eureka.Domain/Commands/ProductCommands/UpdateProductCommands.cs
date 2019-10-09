using Eureka.Domain.Entities;
using System.Collections.Generic;

namespace Eureka.Domain.Commands.ProductCommands
{
    public class UpdateProductCommands
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<string> Images { get; set; }
        public ICollection<Category> Categories { get; set; }
        public Brand Brand { get; set; }
    }
}
