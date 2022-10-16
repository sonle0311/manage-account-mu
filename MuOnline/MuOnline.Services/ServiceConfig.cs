using Autofac;
using MuOnline.Services.Abstractions;

namespace MuOnline.Services
{
    public class ServiceConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(GetType().Assembly)
                .Where(type => typeof(IBaseService).IsAssignableFrom(type))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
