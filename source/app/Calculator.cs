using System;

namespace app
{
  public class Calculator
  {
    public int add(int first, int second)
    {
        if (first > 1 && second < 1)
            throw new ArgumentException();

        if (second > 1 && first < 1)
            throw new ArgumentException();



        return first + second;
    }
  }
}