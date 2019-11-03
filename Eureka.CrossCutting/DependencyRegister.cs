using Eureka.ApplicationService.Services;
using Eureka.Domain.Repositories;
using Eureka.Domain.Services;
using Eureka.Infra;
using Eureka.Infra.Persistence.DataContexts;
using Eureka.Infra.Repositories;
using Eureka.SharedKernel;
using Eureka.SharedKernel.Events;
using Unity;
using Unity.Lifetime;

namespace Eureka.CrossCutting
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<EurekaDataContext, EurekaDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<ICustomerApplicationService, CustomerApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICustomerRepository, CustomerRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}
