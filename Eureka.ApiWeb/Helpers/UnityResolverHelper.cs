using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;

namespace Eureka.ApiWeb.Helpers
{
    public class UnityResolverHelper : IDependencyResolver
    {
        protected IUnityContainer _container;

        public UnityResolverHelper(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this._container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityResolverHelper(child);
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}