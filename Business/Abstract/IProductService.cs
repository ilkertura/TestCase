using Business.Models;
using Core.Utilities.Results;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product entity);
        IResult Update(Product entity);
        IResult Delete(Product product);
    }
}
