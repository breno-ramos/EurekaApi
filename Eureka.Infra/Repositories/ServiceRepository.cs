using Eureka.Domain.Entities;
using Eureka.Domain.Repositories;
using Eureka.Infra.Persistence.DataContexts;
using System.Data.Entity;

namespace Eureka.Infra.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private EurekaDataContext _context;

        public ServiceRepository(EurekaDataContext context)
        {
            _context = context;
        }

        public void Create(Service service)
        {
            _context.Services.Add(service);
        }

        public void Delete(Service service)
        {
            _context.Services.Remove(service);
        }

        public void Update(Service service)
        {
            _context.Entry<Service>(service).State = EntityState.Modified;
        }
    }
}
