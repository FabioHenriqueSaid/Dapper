using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dapper.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "fabio",
                "said",
                "13223232",
                "fabiohenrique@gmail.com",
                "rua dos prazees") ;

        }
    }
}
