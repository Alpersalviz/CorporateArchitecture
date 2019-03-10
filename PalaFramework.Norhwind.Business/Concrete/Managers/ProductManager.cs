using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalaFramework.Norhwind.Business.Abstract;
using PalaFramework.Northwind.DataAccess.Abstract;
using PalaFramework.Northwind.Entities.Concrete;

namespace PalaFramework.Norhwind.Business.Concrete.Managers
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();

        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);

        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
    }
}
