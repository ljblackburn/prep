using System;
using System.Data;

namespace prep.collections
{
  public class Calculator
  {
    IDbConnection databaseConnection;
    public Calculator(IDbConnection databaseConnection)
    {
        this.databaseConnection = databaseConnection;
    }
    public int add(int i, int i1)
    {
        databaseConnection.Open();

        if ((i < 0) || (i1 < 0))
            throw new ArgumentException();

        return i + i1;
    }
  }
  
}