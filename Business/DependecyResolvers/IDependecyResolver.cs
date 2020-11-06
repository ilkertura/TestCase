namespace Business.DependecyResolvers
{
    public interface IDependecyResolver
    {
        T Resolve<T>();
    }
}
