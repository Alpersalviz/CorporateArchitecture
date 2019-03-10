using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalaFramework.Core.Entities;
using PalaFramework.Northwind.DataAccess.Abstract;
using PalaFramework.Northwind.Entities.Concrete;

namespace PalaFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>, ICategoryDal
    {
    }
}
