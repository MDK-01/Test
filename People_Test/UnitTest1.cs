using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AutotestApplicationExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {

        People PeopleTestTask = new People("Hvastunov", "admin", "exeee@mail.ru", "8(555)335-35-35");

        [TestMethod]
        public void TestMethodLogin()
        {
            Assert.AreEqual("HvastunovLogin", PeopleTestTask.login1);
        }
        [TestMethod]
        public void TestMethodPassword()
        {
            Assert.AreEqual("admin", PeopleTestTask.password1);
        }
        [TestMethod]
        public void TestMethodEmail()
        {
            Assert.AreEqual("exeee@mail.ru", PeopleTestTask.email1);
        }
        [TestMethod]
        public void TestMethodPhone()
        {
            Assert.AreEqual("8(555)335-35-35", PeopleTestTask.phone1);
        }
    }
}
