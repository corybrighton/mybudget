using System;
using System.Data;
using System.Linq;
using mybudget.Models;
using Dapper;

namespace mybudget.Repositories
{
  class BanksRepository
  {
    private readonly IDbConnection _db;

    public BanksRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}