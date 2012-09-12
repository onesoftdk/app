using System;
using System.Data;
using System.Security;
using System.Threading;

namespace app
{
    public class Calculator
    {
        IDbConnection connection;

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

      public void shut_off()
      {
        if(!Thread.CurrentPrincipal.IsInRole("SHUT_ACCESS")) throw new SecurityException();
        
      }
    }
}