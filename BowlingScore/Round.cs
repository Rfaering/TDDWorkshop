using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScore {
  public class Round {

    public Frame[] Frames { get; private set; }

    public int FrameNumber { get; set; }

    public Round() {
      Frames = new Frame[10];
      for ( int i = 0; i < 10; i++ ) {
        Frames[i] = new Frame();       
      }
      FrameNumber = 0;
    }

    public void Throw(int pins) {
      List<int> throws = Frames[FrameNumber].Throws;
      if(throws.Count >= 2) {
        FrameNumber++;
      }
      Frames[FrameNumber].AddToFrameScore( pins );
    }
  }
}
