using MsBackend.Business.Abstract;
using MsBackend.Business.Constant;
using MsBackend.Core.Utilities.Result;
using MsBackend.DataAccess.Abstract;
using MSBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MsBackend.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdd);
          
        }
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return  new SuccessDataResult<Product>(_productDal.Get(x => x.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return  new SuccessDataResult<List<Product>>(_productDal.GetList());
                       
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
           return  new SuccessDataResult<List<Product>>(_productDal.GetList(x=>x.CategoryId == categoryId));   
        }

        public  IResult Update (Product product)
        {
            _productDal.Update(product);

            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
