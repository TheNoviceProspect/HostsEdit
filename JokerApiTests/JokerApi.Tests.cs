using System;
using JokerApi;
using NUnit.Framework;

namespace JokerApi.Tests
{
    [TestFixture, Category("BasicTests")]
    public class JokerApiTestFixture
    {
        int a = 10;
        int b = 2;
        
        [Test, Category("Math")]
        public void AddTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.AddNums(a,b);
            Assert.AreEqual(result,12);
        }
        [Test, Category("Math")]]
        public void SubTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.SubNums(a, b);
            Assert.AreEqual(result, 8);
        }
        [Test, Category("Math")]]
        public void MulTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.MulNums(a, b);
            Assert.AreEqual(result, 20);
        }
        [Test, Category("Math")]
        public void DivTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.DivNums(a, b);
            Assert.AreEqual(result, 5);
        }
    }
}