using System;
using System.Data;
using System.Linq;
using mybudget.Models;
using Dapper;

namespace mybudget.Repositories
{
  class SnowBallsRepository
  {
    private readonly IDbConnection _db;

    public SnowBallsRepository(IDbConnection db)
    {
      _db = db;
    }

    // Create Snowball TODO
    // Add Account TODO
    // Get Snowball TODO
    public SnowBall GetSnowBall(String user)
    {
      return _db.QueryFirstOrDefault<SnowBall>("SELECT * FROM SnowBall WHERE UserID = @user", new { user });
    }
    // Get Accounts TODO
    // Update Snowball TODO
    // Remove Account TODO
  }
}