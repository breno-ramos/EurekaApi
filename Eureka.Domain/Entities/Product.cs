using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Entities;
using Eureka.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eureka.Domain.Entities
{
    public class Product : Entity
    {
        private IList<Image> _images;

        public Product(string name, string description, decimal price, IList<Category> categories, Brand brand, Model model)
        {
            Name = name;
            Description = description;
            Price = price;
            Status = EStatusType.Active;
            CreationDate = DateTime.Now;
            EndDate = null;
            _images = new List<Image>();
            Categories = categories;
            Brand = brand;
            Model = model;

            this.ValidName();
            this.ValidPrice();
            this.ValidDescription();
            this.ValidImage();
            this.ValidCategory();
            this.ValidBrand();
            // todo model valid
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public EStatusType Status { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public ICollection<Image> Images { get { return _images.ToArray(); } }
        public ICollection<Category> Categories { get; private set; }
        public Brand Brand { get; private set; }
        public Model Model { get; private set; }

        public void AddImages(List<Image> images)
        {
            foreach (var image in images)
                _images.Add(image);
        }
    }
}
