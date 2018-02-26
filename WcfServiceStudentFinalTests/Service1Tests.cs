using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceStudentFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceStudentFinal.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void Service1Test()
        {
            //arrange
            Service1 service = new Service1();
            //act 
            service.AddStudent("Jonas", "9A", 2);
        }

        [TestMethod()]
        public void AddStudentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindStudentsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllStudentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveStudentTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EditStudentTest()
        {
            Assert.Fail();
        }
    }
}