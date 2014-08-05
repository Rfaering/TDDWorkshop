using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScore {
  public class Frame {

    public int Score { get; set; }

    public List<int> Throws { get; set; }

    public Frame() {
      Score = 0;
      Throws = new List<int>();
    }

    public void CalculateFrameScore( ) {
      if ( Throws.Any( x => x < 0 ) ) {
        throw new InvalidThrowException( "Negative throw value" );
      }

      if ( Throws.Sum() > 10 ) {
        throw new InvalidThrowException( "Value of throw to high" );
      }

      if ( Throws.Count > 2 ) {
        throw new InvalidThrowException( "To many throws" );
      }
      Score = Throws.Sum();
    }

    public void AddToFrameScore(int pins) {
      Throws.Add( pins );
      CalculateFrameScore();
    }
  }
}
