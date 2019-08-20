using NUnit.Framework;
using System;

namespace MvcMovie.Controllers
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            HelloWorldController uut = new HelloWorldController();
            Assert.AreEqual("don't know yet", uut.Welcome("Ngan", 2));
        }
    }
}
