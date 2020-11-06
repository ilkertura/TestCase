using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependecyResolvers.Ninject
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductDAL>().To<EfProductDal>();
            Bind<IUserDAL>().To<EfUserDal>();
        }
    }
}
