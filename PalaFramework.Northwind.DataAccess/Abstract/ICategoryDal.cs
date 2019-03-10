using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalaFramework.Core.DataAccess;
using PalaFramework.Northwind.Entities.Concrete;

namespace PalaFramework.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
