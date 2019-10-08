using Eureka.Domain.Scopes;
using Eureka.Domain.Shared.Entities;
using System.Collections.Generic;

namespace Eureka.Domain.Entities
{
    public class Service : Entity
    {
        public Service(string title, string phone, string description)
        {
            Title = title;
            Phone = phone;
            Description = description;
            Pictures = new List<string>();

            this.ValidTitle();
            this.ValidPhone();
            this.ValidDescription();
        }

        public string Title { get; private set; }
        public string Phone { get; private set; }
        public string Description { get; private set; }
        public string Site { get; private set; }
        public IList<string> Pictures { get; private set; }

        public void AddPictures(List<string> pictures)
        {
            foreach (var picture in pictures)
                this.Pictures.Add(picture);
        }

        public void AddSite(string site) => this.Site = site;
    }
}
