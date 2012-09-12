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
            if (first < 0 || second < 0) throw new ArgumentException();

            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.ExecuteNonQuery();
            return first + second;
        }
    }
}