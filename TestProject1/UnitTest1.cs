using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(GaussAdditionProj.Class1.AddTwo(3, 5), (8));
        }
    }
}