using System;
using JokerApi;
using NUnit.Framework;

namespace JokerApiTests
{
    //[TestFixture]
    public class JokerApiTests
    {
        int a = 10;
        int b = 2;
        
        //[Test]
        public void AddTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.AddNums(a,b);
            Assert.AreEqual(result,12);
        }
        //[Test]
        public void SubTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.SubNums(a, b);
            Assert.AreEqual(result, 8);
        }
        //[Test]
        public void MulTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.MulNums(a, b);
            Assert.AreEqual(result, 20);
        }
        //[Test]
        public void DivTest()
        {
            JokerHelper myTest = new JokerApi.JokerHelper();
            int result = myTest.DivNums(a, b);
            Assert.AreEqual(result, 5);
        }
    }
}