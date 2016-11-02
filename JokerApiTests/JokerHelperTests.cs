using Microsoft.VisualStudio.TestTools.UnitTesting;
using JokerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerApi.Tests
{
    [TestClass()]
    public class JokerHelperTests
    {
        int a = 10;
        int b = 2;

        [TestMethod()]
        public void AddTest()
        {
            JokerHelper myHelper = new JokerHelper();
            int expectedResult = myHelper.AddNums(a, b);
            Assert.IsTrue(expectedResult == 12);
        }

        [TestMethod()]
        public void DivTest()
        {
            JokerHelper myHelper = new JokerHelper();
            int expectedResult = myHelper.DivNums(a, b);
            Assert.IsTrue(expectedResult == 5);
        }

        [TestMethod()]
        public void DivByZeroTest() 
        {
            JokerHelper myHelper = new JokerHelper();
            int expectedResult = myHelper.DivNums(a, 0);
            Assert.IsTrue(expectedResult == 0);
        }

        [TestMethod()]
        public void MulTest()
        {
            JokerHelper myHelper = new JokerHelper();
            int expectedResult = myHelper.MulNums(a, b);
            Assert.IsTrue(expectedResult == 20);
        }

        [TestMethod()]
        public void SubTest()
        {
            JokerHelper myHelper = new JokerHelper();
            int expectedResult = myHelper.SubNums(a, b);
            Assert.IsTrue(expectedResult == 8);
        }
    }
}