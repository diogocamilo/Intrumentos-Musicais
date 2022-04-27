
using Autofac;
using Autofac.Integration.WebApi;
using Repository.Contracts;
using Repository.Repositories;
using Service;
using Service.Contracts;
using System.Reflection;
using System.Web.Http;

namespace Api.App_Start
{
    public static class AutofacConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // service
            builder.RegisterType<MusicalInstrumentService>().As<IMusicalInstrumentService>();

            // repository
            builder.RegisterType<MusicalInstrumentRepository>().As<IMusicalInstrumentRepository>();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }

    }
}