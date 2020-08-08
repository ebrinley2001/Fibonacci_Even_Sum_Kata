using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiboEven;

namespace FiboEven.Tests
{
    [TestClass()]
    public class FibonacciFuncTests
    {
        [DataTestMethod]

        [DataRow(20, 10)]
        [DataRow(40, 44)]
        [DataRow(4000000, 4613732)]


        public void Fibo_Test(int a, int b)
        {
            Assert.AreEqual(b, FibonacciFunc.Fibo_Func(a));
        }

        
    }
}