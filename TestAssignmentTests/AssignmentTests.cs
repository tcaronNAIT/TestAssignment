using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAssignmentTests
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void Test_SimpleMethod_TestPassed()
        {
            Assert.AreEqual<string>("Hello World", Utilities.HelloWorld());
        }

        [TestMethod]
        public void Test_SimpleMethod_TestFailed()
        {
            Assert.AreEqual<string>("Hello", Utilities.HelloWorld());
        }
    }
}