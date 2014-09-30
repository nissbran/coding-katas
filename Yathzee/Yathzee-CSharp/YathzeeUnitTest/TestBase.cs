using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yathzee;

namespace YathzeeUnitTest
{
    [TestClass]
    public abstract class TestBase
    {
        protected GameEngine Engine;

        [TestInitialize]
        public void Setup()
        {
            Engine = new GameEngine();
        }
    }
}
