using System;

namespace app
{
  public class Calculator
  {
    public int add(int first, int second)
    {
        if(first < 0)
            throw new ArgumentException("can't be negative", "first");

        if (second < 0)
            throw new ArgumentException("can't be negative", "second");

        return first + second;
    }
  }
}