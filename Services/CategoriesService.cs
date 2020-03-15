using System;
using System.Collections.Generic;
using System.Data;
using mybudget.Models;
using mybudget.Repositories;

namespace mybudget.Services
{
  public class CategoriesService
  {
    private readonly AccountsRepository _repo;
    public CategoriesService(AccountsRepository repo)
    {
      _repo = repo;
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