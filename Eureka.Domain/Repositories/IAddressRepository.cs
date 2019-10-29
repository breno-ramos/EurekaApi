using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface IAddressRepository
    {
        void Create(Address address);
        void Update(Address address);
        void Delete(Address address);
    }
}
