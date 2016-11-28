using System.Collections.Generic;
using System.Linq;
using System;

namespace Queen
{
  public class Queen
  {
      private int _queenXCoord;
      private int _queenYCoord;
      private int _targetXCoord;
      private int _targetYCoord;
      private int[] _queenCoord = new int[2];
      private int[] _targetCoord = new int[2];

      public int[] GetQueenCoord();
      {
        return _queenCoord;
      }

      public int[] GetTargetCoord();
      {
        return _targetCoord;
      }

      public int GetQueenXCoord();
      {
        return _queenXCoord;
      }

      public int GetQueenYCoord();
      {
        return _queenYCoord;
      }

      public int GetTargetXCoord();
      {
        return _targetXCoord;
      }

      public int GetTargetYCoord();
      {
        return _targetYCoord;
      }

      public void SetQueenXCoord()//int XCoord)
      {
        //_queenXCoord = XCoord;
        int tempStringX = Console.ReadLine();
        _queenXCoord = int.Parse(tempXString);

      }

      public void SetQueenYCoord()//int YCoord)
      {
        //_queenYCoord = YCoord;
        int tempYString = Console.Readline();
        _queenYCoord = int.Parse(tempYString);
      }

      public void SetTargetXCoord(int XCoord)
      {
        _targetXCoord = XCoord;
      }

      public void SetTargetYCoord(int YCoord)
      {
        _targetYCoord = YCoord;
      }

      public void SetQueenCoord(int x, int y)
      {
        _queenCoord.Add(x);
        _queenCoord.Add(y);
      }

      public bool CheckArray()
      {
        if(_userWordArray.Length == 0)
        {
          return false;
        }
        else
        {
          return true;
        }
      }
  }
}
