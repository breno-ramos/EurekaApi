using Eureka.Infra;
using Eureka.SharedKernel;
using Eureka.SharedKernel.Events;

namespace Eureka.ApplicationService
{
    public class ApplicationServiceBase
    {
        private IUnitOfWork _uow;
        private IHandler<DomainNotification> _notifications;

        public ApplicationServiceBase(IUnitOfWork uow)
        {
            _uow = uow;
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications()) return false;

            _uow.Commit();
            return true;
        }
    }
}
