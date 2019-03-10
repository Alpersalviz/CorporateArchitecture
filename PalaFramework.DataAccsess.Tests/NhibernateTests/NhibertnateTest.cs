using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalaFramework.Northwind.DataAccess.Concrete.EntityFramework;
using PalaFramework.Northwind.DataAccess.Concrete.Nhibernate;
using PalaFramework.Northwind.DataAccess.Concrete.Nhibernate.Helpers;

namespace PalaFramework.DataAccsess.Tests.NhibernateTests
{
    [TestClass]
    public class NhibertnateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(2, result.Count);
        }


        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList(p=> p.ProductName.Contains("as"));

            Assert.AreEqual(1, result.Count);
        }
    }
}
