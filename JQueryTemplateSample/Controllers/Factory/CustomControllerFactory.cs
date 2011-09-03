using System;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Core;
using Castle.MicroKernel.Registration;
using JQueryTemplateSample.Models.Container;

namespace JQueryTemplateSample.Controllers.Factory
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        public CustomControllerFactory()
        {
            BasedOnDescriptor controllers = AllTypes
                .FromThisAssembly()
                .BasedOn(typeof (IController))
                .Configure(c => c.LifeStyle.Is(LifestyleType.Transient));

            ContainerService.Instance.Register(controllers);
        }

        protected override IController GetControllerInstance(
            RequestContext requestContext, Type controllerType)
        {
            if (controllerType != null)
            {
                return (IController) ContainerService.Instance.Resolve(controllerType);
            }

            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}