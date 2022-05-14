using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });
            Assert.That(actual == 12);
        }
        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long actual = Summator.Sum(new int[] { 9 });
            Assert.That(actual == 9);
        }
        [Test]
        public void Test_Sum_OneNegativeNumber()
        {
            long actual = Summator.Sum(new int[] { -9 });
            Assert.That(actual == -9);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long expected = Summator.Sum(new int[] { -9, -6 });
            Assert.That(expected == -15);
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_TwoBigNumbers()
        {

            long expected = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(8000000000, expected);
        }
        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 10, 15 });

            int expected = 10;

            Assert.That(expected == actual);
        }
    }
}
