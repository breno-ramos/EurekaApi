using Eureka.SharedKernel.Events;
using System.Collections.Generic;
using System.Linq;

namespace Eureka.SharedKernel.Validation
{
    public static class AssertionConcern
    {
        public static bool IsValid(params DomainNotification[] validations)
        {
            var notificationsNotNull = validations.Where(validation => validation != null);
            NotifyAll(notificationsNotNull);

            return notificationsNotNull.Count().Equals(0);
        }

        public static void NotifyAll(IEnumerable<DomainNotification> notifications)
        {
            notifications.ToList().ForEach(validation =>
            {
                DomainEvent.Raise<DomainNotification>(validation);
            });
        }
    }
}
