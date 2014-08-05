using BowlingScore;
using NUnit.Framework;


namespace BowlingScoreTest
{
    [TestFixture]
    public class BowlingScoreServiceTest
    {
        private BowlingScoreService _target;

        [SetUp]
        public void Initialize()
        {
            _target = new BowlingScoreService();
        }

        [Test]
        public void Given_BowlingService_When_CalculateScoreCalledWithNoArguments_Then_ZeroReturned()
        {
            var result = _target.CalculateScore();
            Assert.That(result, Is.EqualTo( 0 ));
        }
    }
}
