using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing.Values;
using NHibernate.Mapping;
using PalaFramework.Core.DataAccess;
using PalaFramework.Northwind.Entities.ComplexTypes;
using PalaFramework.Northwind.Entities.Concrete;

namespace PalaFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
