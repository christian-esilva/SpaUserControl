using SpaUserControl.Business.Services;
using SpaUserControl.Domain.Contracts.Repositories;
using SpaUserControl.Domain.Contracts.Services;
using SpaUserControl.Domain.Entities;
using SpaUserControl.Infrastructure.Data;
using SpaUserControl.Repositories.Infrastructure;
using Unity;
using Unity.Lifetime;

namespace SpaUserControl.Startup
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());

            container.RegisterType<User, User>(new HierarchicalLifetimeManager());
        }
    }
}
