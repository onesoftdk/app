﻿using System;
using System.Data;

namespace app
{
  public class Calculator
  {
      private IDbConnection _connection;

      public Calculator() { }

      public Calculator(IDbConnection connection)
      {
          _connection = connection;
      }

    public int add(int first, int second)
    {
        if (first > 1 && second < 1)
            throw new ArgumentException();

        if (second > 1 && first < 1)
            throw new ArgumentException();

        _connection.Open();

        return first + second;
    }
  }
}