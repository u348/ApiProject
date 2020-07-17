using ApiProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var jsonSerializer = new JsonSerializer();

            var jsonString = jsonSerializer.SerializeJson(
                "Test description.",
                "12345");
        }
    }
}
