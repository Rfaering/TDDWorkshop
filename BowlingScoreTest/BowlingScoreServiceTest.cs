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
        
      [Test]
      public void Given_BowlingService_When_CalculateScoreCalledWithArguments_Then_Sum() {
        var result = _target.CalculateScore( 5, 4 );
        Assert.That( result, Is.EqualTo( 9 ) );
      }

      [Test]
      [ExpectedException(typeof(InvalidThrowException))]
      public void Negative_Input() {
        _target.CalculateScore( -2, -5 );
        
      }


      [Test]
      [ExpectedException(typeof(InvalidThrowException))]
      public void Positive_Negative_Input() {
        _target.CalculateScore( 6, -5 );

      }

      [Test]
      [ExpectedException(typeof(InvalidThrowException))]
      public void Throw_Value_To_High() {
        _target.CalculateScore( 11 );
      }

      [Test]
      [ExpectedException(typeof(InvalidThrowException))]
      public void To_Many_Arguments() {
        _target.CalculateScore( 1, 1, 3 );
      }

      [Test]
      public void New_Round_Create() {
        Round round = new Round();
        Assert.That(round.Frames.Length, Is.EqualTo( 10 ));
        Assert.That( round.Frames[0].Score, Is.EqualTo( 0 ) );
        Assert.That( round.Frames[0].Throws.Count, Is.EqualTo( 0 ) );
      }

      [Test]
      public void Round_Two_Frames_Played() {
        Round round = new Round();
        round.Throw( 3 );
        round.Throw( 5 );
        round.Throw( 7 );
        round.Throw( 2 );
        Assert.That( round.Frames[0].Score, Is.EqualTo( 8 ) );
        Assert.That( round.Frames[1].Score, Is.EqualTo( 9 ) );
      }
      [Test]
      public void Round_Two_Frames_Played_Different_input() {
        Round round = new Round();
        round.Throw( 2 );
        round.Throw( 5 );
        round.Throw( 4 );
        round.Throw( 2 );
        Assert.That( round.Frames[0].Score, Is.EqualTo( 7 ) );
        Assert.That( round.Frames[1].Score, Is.EqualTo( 6 ) );
      }
    }
    
      
}
