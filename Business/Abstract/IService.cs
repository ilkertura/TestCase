using Business.Models;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IService<T, TFilter> where T : class 
    {
        IEnumerable<T> GetAll(TFilter filter);
        T Get(TFilter filter);        
        T Add(T entity);
        T Update(T entity);
        bool Delete(int id);
    }
}
