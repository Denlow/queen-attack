using Xunit;
using System.Collections.Generic;
using System;

namespace Queen
{
  public class QueenTest
  {
    [Fact]
    Queen userQueen = new Queen();
    userQueen.SetQueenXCoord();
    userQueen.SetQueenYCoord();
    int x = userQueen.GetQueenXCoord();
    int y = userQueen.GetQueenYCoord();

    userQueen.SetQueenCoord(x, y)
  }
}
