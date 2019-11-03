using Eureka.Domain.Shared.Entities;

namespace Eureka.Domain.Entities
{
    public class Image : Entity
    {
        public Image(string title, string description, string url)
        {
            Title = title;
            Description = description;
            Url = url;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Url { get; private set; }
    }
}
