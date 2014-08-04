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
        public void Given_BowlingService_When_CalculateScoreCalledWithNoArguments_Then_ZeroReturned()
        {
            var result = _target.CalculateScore();
            Assert.AreEqual(0, result);
        }
    }
}
