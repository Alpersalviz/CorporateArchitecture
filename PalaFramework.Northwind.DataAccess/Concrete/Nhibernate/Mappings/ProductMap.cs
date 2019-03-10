﻿using System;
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
    public class ProductMap:ClassMap<Product>
    {

        public ProductMap()
        {
            Table(@"Products");

            LazyLoad();

            Id(x => x.ProductId).Column("ProductID");

            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
            Map(x => x.UnitPrice).Column("UnitPrice");
        }
      
    }
}
