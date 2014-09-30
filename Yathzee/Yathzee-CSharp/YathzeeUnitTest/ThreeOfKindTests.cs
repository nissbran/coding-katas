using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Yathzee.Rules;

namespace YathzeeUnitTest
{
    [TestClass]
    public class ThreeOfKindTests : TestBase
    {
        [TestMethod]
        public void TestThreeOfKind()
        {
            // Arrange
            var testdata = new List<int> { 1, 1, 1, 6, 6 };

            // Act
            int score = Engine.CalculateScore(testdata, new ThreeOfKindRule());

            // Assert
            Assert.AreEqual(3, score);
        }

        [TestMethod]
        public void TestThreeOfKind_Sixes()
        {
            // Arrange
            var testdata = new List<int> { 1, 1, 6, 6, 6 };

            // Act
            int score = Engine.CalculateScore(testdata, new ThreeOfKindRule());

            // Assert
            Assert.AreEqual(18, score);
        }
    }
}
