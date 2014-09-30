using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Yathzee.Rules;

namespace YathzeeUnitTest
{
    [TestClass]
    public class SingleTests : TestBase
    {
        [TestMethod]
        public void TestOnes()
        {
            // Arrange
            var testdata = new List<int> { 1, 1, 3, 4, 5 };

            // Act
            int score = Engine.CalculateScore(testdata, new SumRule(1));

            // Assert
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void TestTwos()
        {
            // Arrange
            var testdata = new List<int> { 2, 2, 2, 4, 5 };

            // Act
            int score = Engine.CalculateScore(testdata, new SumRule(2));

            // Assert
            Assert.AreEqual(6, score);
        }

        [TestMethod]
        public void TestThrees()
        {
            // Arrange
            var testdata = new List<int> { 3, 4, 3, 3, 6 };

            // Act
            int score = Engine.CalculateScore(testdata, new SumRule(3));

            // Assert
            Assert.AreEqual(9, score);
        }

        [TestMethod]
        public void TestFours()
        {
            // Arrange
            var testdata = new List<int> { 3, 4, 3, 4, 4 };

            // Act
            int score = Engine.CalculateScore(testdata, new SumRule(4));

            // Assert
            Assert.AreEqual(12, score);
        }

        [TestMethod]
        public void TestFives()
        {
            // Arrange
            var testdata = new List<int> { 5, 5, 5, 5, 4 };

            // Act
            int score = Engine.CalculateScore(testdata, new SumRule(5));

            // Assert
            Assert.AreEqual(20, score);
        }

        [TestMethod]
        public void TestSixes()
        {
            // Arrange
            var testdata = new List<int> { 5, 6, 1, 6, 4 };

            // Act
            int score = Engine.CalculateScore(testdata, new SumRule(6));

            // Assert
            Assert.AreEqual(12, score);
        }
    }
}
