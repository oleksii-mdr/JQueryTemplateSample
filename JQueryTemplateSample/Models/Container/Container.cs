using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace JQueryTemplateSample.Models.Container
{
    public class Container : IContainer
    {
        private static bool isConfigured;
        private IWindsorContainer container;

        #region IContainer Members

        public void Register(params IRegistration[] regParams)
        {
            Initialize();
            container.Register(regParams);
        }

        public object Resolve(Type type)
        {
            return container.Resolve(type);
        }

        #endregion

        public T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public IWindsorContainer Initialize()
        {
            if (!isConfigured)
            {
                container = new WindsorContainer();
                container.Register(Component.For<IDepartmentRepository>()
                                       .ImplementedBy<DeparmentRepository>());

                isConfigured = true;
            }

            return container;
        }
    }
}