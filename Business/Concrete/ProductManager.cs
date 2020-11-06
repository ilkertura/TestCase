using Business.Abstract;
using Business.Constants;
using Business.DependecyResolvers.Ninject;
using Business.Models;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;
        public ProductManager()
        {
            _productDAL = NinjectDependencyResolver.Resolve<IProductDAL>();
        }
        public IResult Add(Product product)
        {
            //Business codes
            _productDAL.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDAL.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Product product)
        {
            _productDAL.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDAL.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetAll()
        {
            var products = _productDAL.GetAll();
            return new SuccessDataResult<List<Product>>(products.ToList());
        }


    }
}
