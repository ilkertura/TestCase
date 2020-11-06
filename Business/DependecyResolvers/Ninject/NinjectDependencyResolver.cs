using Ninject;
using System.Reflection;

namespace Business.DependecyResolvers.Ninject
{
    public class NinjectDependencyResolver
    {
        public static T Resolve<T>()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel.Get<T>();
        }
    }
}
