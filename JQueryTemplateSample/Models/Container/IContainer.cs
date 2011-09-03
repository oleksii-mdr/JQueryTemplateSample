using System;
using Castle.MicroKernel.Registration;

namespace JQueryTemplateSample.Models.Container
{
    /// <summary>
    /// Describes interface of IoC contianer
    /// </summary>
    public interface IContainer
    {
        void Register(params IRegistration[] regParams);
        object Resolve(Type type);
    }
}