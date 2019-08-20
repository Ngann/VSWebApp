using NUnit.Framework;

namespace MvcMovie.Controllers
{
    [TestFixture]
    public class HelloWorldControllerTests
    {
        [Test]
        public void WelcomeTests()
        {
            HelloWorldController uut = new HelloWorldController();
            Assert.AreEqual("don't know yet", uut.Welcome("Ngan", 2));
        }
    }
}
