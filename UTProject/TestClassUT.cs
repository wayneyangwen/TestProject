using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace UTProject
{
    [TestClass]
    public class TestClassUT
    {
        [TestMethod]
        public void TestEmployee()
        {
            Test testClass = new Test();

            int testNumber = 6;

            int result = 0;

            result =  testClass.Product(testNumber);


        }
    }
}
