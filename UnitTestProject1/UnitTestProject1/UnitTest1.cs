using System;

using NUnit.Framework;
namespace UnitTestProject1
{

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethodPass()
        { //new remote branch
            Assert.IsTrue(true);
            
        }
        [Test]
        public void TestMethodFail()
        { //test branch  
            Assert.IsTrue(true);

        }
    }
}
//fetch commit