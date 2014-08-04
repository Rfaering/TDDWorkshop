using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingScore;

namespace BowlingScoreTest
{
    [TestClass]
    public class BowlingScoreServiceTest
    {
        private BowlingScoreService _target;

        [TestInitialize]
        public void Initialize()
        {
            _target = new BowlingScoreService();
        }

        [TestMethod]
        public void GiveBowlingServiceWhenTestMethodCalledThenZeroReturned()
        {
            var result = _target.CalculateScore();
            Assert.AreEqual(0, result);
        }
    }
}
