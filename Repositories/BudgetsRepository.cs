using System;
using System.Data;
using System.Linq;
using mybudget.Models;
using Dapper;

namespace mybudget.Repositories
{
  class BudgetsRepository
  {
    private readonly IDbConnection _db;

    public BudgetsRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}