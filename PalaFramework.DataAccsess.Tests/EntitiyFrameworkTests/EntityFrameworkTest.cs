using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalaFramework.Northwind.DataAccess.Concrete.EntityFramework;

namespace PalaFramework.DataAccsess.Tests.EntitiyFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(2, result.Count);
        }


        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p=> p.ProductName.Contains("as"));

            Assert.AreEqual(1, result.Count);
        }
    }
}
