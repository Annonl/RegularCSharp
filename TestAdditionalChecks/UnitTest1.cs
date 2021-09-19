using Microsoft.VisualStudio.TestTools.UnitTesting;
using Additional—hecks;

namespace TestAdditionalChecks
{
    [TestClass]
    public class UnitTestStringExtension
    {
        [TestMethod]
        public void TestMethodGetTime1()
        {
            string str = "«‡‚Ú‡Í ‚ 09:00.";
            string result = str.GetTime();
            Assert.AreEqual("09:00", result);
        }
        [TestMethod]
        public void TestMethodGetTime2()
        {
            string str = " 59:31     23:59     111111:222222";
            string result = str.GetTime();
            Assert.AreEqual("23:59", result);
        }
        [TestMethod]
        public void TestMethodGetTime3()
        {
            string str = "12:87 56:58 24:00";
            string result = str.GetTime();
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void TestMethodIsMacAdress1()
        {
            string str = "aE:dC:cA:56:76:54";
            Assert.IsTrue(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress2()
        {
            string str = "aE:dC:cA:56:76:5";
            Assert.IsFalse(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress3()
        {
            string str = "01:23:45:67:89:Az";
            Assert.IsFalse(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress4()
        {
            string str = "00:00:00:00:00:00";
            Assert.IsTrue(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress1()
        {
            string str = "ales.kolpa@gmail.com";
            Assert.IsTrue(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress2()
        {
            string str = "ales..kolpa@gmail.com";
            Assert.IsFalse(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress3()
        {
            string str = "ales.kolpa.@yandex.ru";
            Assert.IsFalse(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress4()
        {
            string str = ".ales.kolpa@gmail.com";
            Assert.IsFalse(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress5()
        {
            string str = "root@localhost";
            Assert.IsTrue(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress6()
        {
            string str = " @val.ru";
            Assert.IsFalse(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress7()
        {
            string str = "Just Text 2";
            Assert.IsFalse(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword1()
        {
            string str = "C00l_Pass";
            Assert.IsTrue(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword2()
        {
            string str = "SupperPas1";
            Assert.IsTrue(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword3()
        {
            string str = "Cool_pass";
            Assert.IsFalse(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword4()
        {
            string str = "C00l";
            Assert.IsFalse(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword5()
        {
            string str = "Ab1Avc2";
            Assert.IsFalse(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword6()
        {
            string str = "WeWe1234";
            Assert.IsTrue(str.IsStrongPassword());
        }

    }
}
