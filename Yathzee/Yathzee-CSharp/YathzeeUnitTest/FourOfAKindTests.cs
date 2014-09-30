using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Yathzee.Rules;

namespace YathzeeUnitTest
{
    [TestClass]
    public class FourOfAKindTests : TestBase
    {
        [TestMethod]
        public void TestFourOfAKind()
        {
            // Arrange
            var testdata = new List<int> { 1, 1, 1, 1, 6 };

            // Act
            int score = Engine.CalculateScore(testdata, new FourOfAKindRule());

            // Assert
            Assert.AreEqual(4, score);
        }
    }
}
