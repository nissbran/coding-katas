using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Yathzee.Rules;

namespace YathzeeUnitTest
{
    [TestClass]
    public class PairsTests : TestBase
    {
        [TestMethod]
        public void TestPairs()
        {
            // Arrange
            var testdata = new List<int> { 1, 1, 3, 6, 6 };

            // Act
            int score = Engine.CalculateScore(testdata, new PairRule());

            // Assert
            Assert.AreEqual(12, score);
        }

        [TestMethod]
        public void TestTwoPairs()
        {
            // Arrange
            var testdata = new List<int> { 2, 2, 3, 6, 6 };

            // Act
            int score = Engine.CalculateScore(testdata, new TwoPairsRule());

            // Assert
            Assert.AreEqual(16, score);
        }
    }
}
