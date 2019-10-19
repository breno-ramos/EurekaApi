using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;
using System.Data.Entity;

namespace Eureka.Infra.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private EurekaDataContext _context;

        public AddressRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Address address)
        {
            _context.Addresses.Add(address);
        }

        public void Delete(Address address)
        {
            _context.Addresses.Remove(address);
        }

        public void Update(Address address)
        {
            _context.Entry<Address>(address).State = EntityState.Modified;
        }
    }
}
