using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionalСhecks;

namespace TestAdditionalChecks
{
    [TestClass]
    public class UnitTestStringExtension
    {
        [TestMethod]
        public void TestMethodGetTime1()
        {
            string str = "Завтрак в 09:00.";
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
        public void TestMethodGetTime4()
        {
            string str = "";
            string result = str.GetTime();
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void TestMethodGetTime5()
        {
            string str = "Сегодня в 9:00 будет футбол.";
            string result = str.GetTime();
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void TestMethodGetTime6()
        {
            string str = "37:98";
            string result = str.GetTime();
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void TestMethodGetTime7()
        {
            string str = "абвгд:00";
            string result = str.GetTime();
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void TestMethodGetTime8()
        {
            string str = "Занятия начинаются в 10:00.";
            string result = str.GetTime();
            Assert.AreEqual("10:00", result);
        }
        [TestMethod]
        public void TestMethodGetTime9()
        {
            string str = "00:00";
            string result = str.GetTime();
            Assert.AreEqual("00:00", result);
        }
        [TestMethod]
        public void TestMethodGetTime10()
        {
            string str ="Время 111::15 23:59";
            string result = str.GetTime();
            Assert.AreEqual("23:59", result);
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
            string str = "01:23:45:6T:89:Az";
            Assert.IsFalse(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress4()
        {
            string str = "This is Mac: 00:00:00:00:00:00";
            Assert.IsFalse(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress5()
        {
            string str = "aa:aa:aa:aa:aa:aa:aa:aa";
            Assert.IsFalse(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress6()
        {
            string str = "00:00:00:00:00:00:";
            Assert.IsFalse(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress7()
        {
            string str = "00:00:00:00:00:00";
            Assert.IsTrue(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress8()
        {
            string str = "8A:D2:B4:EE:C2:EF";
            Assert.IsTrue(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress9()
        {
            string str = "8a:b5:1e:14:e6:68";
            Assert.IsTrue(str.IsMacAdress());
        }
        [TestMethod]
        public void TestMethodIsMacAdress10()
        {
            string str = "ff:ff:ff:ff:ff:ff";
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
        public void TestMethodIsEmailAdress8()
        {
            string str = "pidebi7127@mainctu.com";
            Assert.IsTrue(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress9()
        {
            string str = "elz00186@zwoho.com";
            Assert.IsTrue(str.IsEmailAdress());
        }
        [TestMethod]
        public void TestMethodIsEmailAdress10()
        {
            string str = "lebibe1703@jasmne.com";
            Assert.IsTrue(str.IsEmailAdress());
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
        [TestMethod]
        public void TestMethodIsStrongPassword7()
        {
            string str = "StrongPassword";
            Assert.IsFalse(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword8()
        {
            string str = "123456789";
            Assert.IsFalse(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword9()
        {
            string str = "1muVcjkEfy";
            Assert.IsTrue(str.IsStrongPassword());
        }
        [TestMethod]
        public void TestMethodIsStrongPassword10()
        {
            string str = "uS9bP3ey7XMWgUa6HZ0R2vlP";
            Assert.IsTrue(str.IsStrongPassword());
        }
    }
}
