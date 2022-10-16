using Autofac;
using Microsoft.EntityFrameworkCore.Design;
using MuOnline.Database.Repositories;
using MuOnline.Database.UnitOfWork;
using MuOnline.Database.EF;

namespace MuOnline.Database
{
    public class DatabaseConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork.UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<MuOnlineDbContextFactory>().As<IDesignTimeDbContextFactory<MuOnlineDbContext>>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(RepositoryWithTPrimaryKey<,>)).As(typeof(IRepositoryWithTPrimaryKey<,>)).InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
