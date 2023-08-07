using Autofac;
using System.Reflection;
//using AutoFacDemo.Interfaces; // required for manual registration

namespace AutoFacDemo
{
    public class Program
    {
        static void Main()
        {
            var container = BuildContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<Application>().Run(); // retrieves type from container
            }
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // manually register classes
            /*builder.RegisterType<Application>(); // registers Application class as itself
            builder.RegisterType<OptionsService>().As<IOptionsService>(); // registers OptionsService as IOptionsService, IOptionsService is requested, OptionsService class is provided
            builder.RegisterType<Printer>().As<IPrinter>(); // as above
            builder.RegisterType<InMemoryNumericStore>().As<INumericStore>(); // as above*/

            // auto register new classes
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces(); // does the same thing as the code above, registers classes as themselves or implemented interfaces

            return builder.Build();
        }
    }
}