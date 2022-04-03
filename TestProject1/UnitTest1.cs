using NUnit.Framework;
using GaussAdditionProj;

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
            Assert.AreEqual(Class1.GaussAddition(1, 100), (5050));
            Assert.AreEqual(Class1.GaussAddition(1, 5000), (12502500));
            Assert.AreEqual(Class1.GaussAddition(3, 5), (12));
            Assert.AreEqual(Class1.GaussAddition(5, 500), (125240));
            Assert.AreEqual(Class1.GaussAddition(28, 123), (7248));
            Assert.AreEqual(Class1.GaussAddition(1800, 250), (1589775));
            Assert.AreEqual(Class1.GaussAddition(1975, 165), (1937770));
        }
    }
}




/*

[TestCase(new long[] { 100 }, Result = 5050)]
[TestCase(new long[] { 1, 100 }, Result = 5050)]
[TestCase(new long[] { 5000 }, Result = 12502500)]
[TestCase(new long[] { 5001, 7000 }, Result = 12001000)]
[TestCase(new long[] { 3, 5 }, Result = 12)]
[TestCase(new long[] { 1800, 250 }, Result = 1589775)]
[TestCase(new long[] { 1, 5000 }, Result = 12502500)]
[TestCase(new long[] { 5, 500 }, Result = 125240)]
[TestCase(new long[] { 1975, 165 }, Result = 1937770)]
[TestCase(new long[] { 50000 }, Result = 1250025000)]
[TestCase(new long[] { 28, 123 }, Result = 7248)]
[TestCase(new long[] { 7000, 5001 }, Result = 12001000)]
[TestCase(new long[] { 0, 100 }, Result = 5050)]
[TestCase(new long[] { 5000, 1 }, Result = 12502500)]
[TestCase(new long[] { 100, 1 }, Result = 5050)]

*/


