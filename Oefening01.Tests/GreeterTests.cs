using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Oefening01.Tests
{
    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void TestHelloJohn()
        {
            // ARRANGE
            Greeter greeter = new Greeter();
            string who = "John";

            // ACT
            string greeting = greeter.Greet(who);

            // ASSERT
            Assert.AreEqual("Hello John", greeting);
        }

        [TestMethod]
        public void TestHelloNULL()
        {
            // ARRANGE
            Greeter greeter = new Greeter();
            string who = null;

            // ACT
            string greeting = greeter.Greet(who);

            // ASSERT
            Assert.AreEqual("Hello ", greeting);
        }
    }
}
