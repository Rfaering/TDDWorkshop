using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScore {
  public class InvalidThrowException : ArgumentException {

    public InvalidThrowException(string message) : base(message) {
      
    }
  }
}
