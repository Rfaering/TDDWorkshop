using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScore
{
    public class BowlingScoreService
    {
        public int CalculateScore(params int[] values) {
          if(values.Any(x => x < 0)) {
            throw new InvalidThrowException( "Negative throw value" );
          }

          if(values.Sum() > 10) {
            throw new InvalidThrowException( "Value of throw to high" );
          }

          if(values.Length > 2) {
            throw new InvalidThrowException( "To many throws" );
          }
          int sum = values.Sum();
          return sum;
        }
    }
}
