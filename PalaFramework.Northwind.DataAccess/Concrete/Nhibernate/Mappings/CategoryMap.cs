using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using PalaFramework.Northwind.Entities.Concrete;

namespace PalaFramework.Northwind.DataAccess.Concrete.Nhibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {

        public CategoryMap()
        {
            Table(@"Categories");

            LazyLoad();

            Id(x => x.CategoryId).Column("CategoryID");
             
            Map(x => x.CategoryName).Column("CategoryName"); 
        }
      
    }
}
