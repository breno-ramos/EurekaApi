using Eureka.Infra;
using Eureka.Infra.Persistence.DataContexts;
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
            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}
