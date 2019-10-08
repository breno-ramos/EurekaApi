using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface IServiceRepository
    {
        void Create(Service service);
        void Update(Service service);
        void Delete(Service service);
    }
}
