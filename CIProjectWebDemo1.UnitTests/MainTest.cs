using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIProjectWebDemo1.UnitTests
{
    public class MainTest
    {
        public Main main;

        [SetUp]
        public void Init()
        {
            main=new Main();
        }
        [Test]
        public void PageTest()
        {
            var result = main.GetLoadDate();
            // Assert
            Assert.IsInstanceOf<string>(result);
            Assert.AreEqual("这是一个测试页面", result);
        }

    }
}
