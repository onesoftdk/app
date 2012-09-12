using System;
using System.Data;

namespace app
{
  public class Calculator
  {
      readonly IDbConnection connection;

      public Calculator(IDbConnection connection)
      {
          this.connection = connection;
      }

      public int add(int first, int second)
    {
        if (first > 1 && second < 1)
            throw new ArgumentException();

        if (second > 1 && first < 1)
            throw new ArgumentException();

          connection.Open();

        return first + second;
    }
  }
}