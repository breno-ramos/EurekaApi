using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Eureka.Domain.Entities
{
    public class Service : Entity
    {
        private IList<Image> _images;

        public Service(string title, string phone, string description)
        {
            Title = title;
            Phone = phone;
            Description = description;
            _images = new List<Image>();

            this.ValidTitle();
            this.ValidPhone();
            this.ValidDescription();
        }

        public string Title { get; private set; }
        public string Phone { get; private set; }
        public string Description { get; private set; }
        public string Site { get; private set; }
        public ICollection<Image> Images { get { return _images.ToArray(); } }

        public void AddImages(List<Image> images)
        {
            foreach (var image in images)
                _images.Add(image);
        }

        public void AddSite(string site) => this.Site = site;
    }
}
