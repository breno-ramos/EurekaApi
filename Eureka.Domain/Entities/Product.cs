using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;
using System;
using System.Collections.Generic;

namespace Eureka.Domain.Entities
{
    public class Product: Entity
    {
        public Product(string name, string description, decimal price, ICollection<string> images, IList<Category> categories, Brand brand)
        {
            Name = name;
            Description = description;
            Price = price;
            Status = EStatusType.Active;
            CreationDate = DateTime.Now;
            EndDate = null;
            Images = images;
            Categories = categories;
            Brand = brand;

            this.ValidName();
            this.ValidPrice();
            this.ValidDescription();
            this.ValidImage();
            this.ValidCategory();
            this.ValidBrand();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public EStatusType Status { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public ICollection<string> Images { get; private set; }
        public ICollection<Category> Categories { get; private set; }
        public Brand Brand { get; private set; }
        // TODO
        // modelo
    }
}
