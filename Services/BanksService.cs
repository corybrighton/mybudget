using System;
using System.Collections.Generic;
using System.Data;
using mybudget.Models;
using mybudget.Repositories;

namespace mybudget.Services
{
  public class BanksService
  {
    private readonly AccountsRepository _repo;
    public BanksService(AccountsRepository repo)
    {
      _repo = repo;
    }

    internal object GetUsersAccounts()
    {
      return _repo.GetUsersAccounts();
    }

    internal object getFlow()
    {
      return _repo.GetFlow();
    }
    // public IEnumerable<Keep> Get()
    // {
    //   return _repo.Get();
    // }

    // public Keep Create(Keep newKeep)
    // {
    //   newKeep.Id = _repo.Create(newKeep);
    //   return newKeep;
    // }
  }
}