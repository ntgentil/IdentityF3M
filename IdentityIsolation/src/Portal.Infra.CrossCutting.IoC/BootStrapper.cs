using Portal.Infra.CrossCutting.Identity.Configuration;
using Portal.Infra.CrossCutting.Identity.Context;
using Portal.Infra.CrossCutting.Identity.Model;
using Portal.Infra.Data.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using Identity.Domain;

namespace Portal.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());


            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);

            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
        } 
    }
}