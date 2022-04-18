using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MainClass;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Ошибка", Application.GetApplication(null, null));
            Assert.AreEqual("Хорошо", TaskList.name("Привет", "Привет"));
            Assert.AreEqual("Ошибка", Task.title(null, null));
        }
    }
}
