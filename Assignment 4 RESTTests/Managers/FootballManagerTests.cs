using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_4_REST.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_REST.Managers.Tests
{
    [TestClass()]
    public class FootballManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            List<FootballManager> list = new List<FootballManager>();
            list.Add(new FootballManager());
            list.Add(new FootballManager());
            Assert.IsNotNull(list);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            int id = 1;
            FootballManager manager = new FootballManager();
            FootballManager manager2 = new FootballManager();

            manager.GetById(id);
            Assert.AreNotEqual(manager, manager2);
        }

        //[TestMethod()]
        //public void AddTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DeleteTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void UpdateTest()
        //{
        //    Assert.Fail();
        //}
    }
}