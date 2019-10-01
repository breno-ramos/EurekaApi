using Eureka.Domain.Entities;

namespace Eureka.Domain.Repositories
{
    public interface IAddressRepository
    {
        void Create(Address branch);
        void Update(Address branch);
        void Delete(Address branch);
    }
}
