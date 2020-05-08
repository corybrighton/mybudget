using System.Collections.Generic;
using System;
using mybudget.Models;
using System.Data;

namespace mybudget.Repositories
{
  public class AccountsRepository
  {
    private readonly IDbConnection _db;
    public AccountsRepository(IDbConnection db)
    {
      _db = db;
    }

    IEnumerable<Bank> tempdata()
    {
      string[] Banksarrys = { "Wells Fargo", "Credit Union", "Chase", "US Bank", "Idaho Credit Union" };

      string[] AccountArray = { "Savings", "Checking", "Credit" };
      Random rand = new Random();

      List<Bank> Banks = new List<Bank>();

      for (int i = 0; i < Banksarrys.Length; i++)
      {
        Banks.Add(new Bank()
        {
          BankName = new BankName()
          {
            Name = Banksarrys[i],
            BankID = i
          }
        });

        Banks[i].Accounts = new List<Account>();
        for (int j = 0; j < AccountArray.Length; j++)
        {
          Banks[i].Accounts.Add(
            new Account()
            {
              Balance = Convert.ToDecimal(rand.NextDouble() * rand.Next(0, 1500)),
              BankID = i,
              ID = j + i,
              AccountType = AccountArray[j],
              UserID = "user"
            }
          );
        }

        Banks[i].Total = Banks[i].getTotal();

      }

      return Banks;
    }

    // Return Banks and Accounts for user
    public IEnumerable<Bank> GetUsersAccounts()
    {

      return tempdata();
      // return _db.Query<Account>("SELECT * FROM Keeps WHERE isPrivate = 0;");
    }

    // Get the total from all banks
    public decimal GetFlow()
    {
      decimal total = 0;
      IEnumerable<Bank> banks = tempdata();
      foreach (Bank bank in banks)
      {
        foreach (Account account in bank.Accounts)
        {
          total += account.Balance;
        }
      }
      return total;
    }

    public Bank editBank(Bank bank)
    {
      return bank;
    }

    // public IEnumerable<Keep> GetUsersKeeps(string user)
    // {
    //   return _db.Query<Keep>("SELECT * FROM keeps WHERE userId = @user", new { user });
    // }

    // public Keep GetById(int id)
    // {
    //   _db.Execute(@"
    //   UPDATE Keeps SET 
    //   views = views + 1
    //   WHERE id = @id;", new { id });
    //   return _db.QueryFirstOrDefault<Keep>("SELECT * FROM Keeps WHERE id = @id;", new { id });
    // }

    // Create
    // public string AddKeep(Keep keep)
    // {
    //   return _db.ExecuteScalar<int>(@"
    // INSERT INTO keeps (name, description, userId, img, isPrivate) VALUES (@Name, @Description, @UserId, @Img, @IsPrivate); 
    // SELECT LAST_INSERT_ID()", keep) != 0
    //     ? "Success" : "Did not add";
    // }

    // internal string UpdateKeepShares(int id)
    // {
    //   _db.Execute("UPDATE keeps SET shares=shares+1 WHERE id=@id", new { id });
    //   return "ok";
    // }

    //   // Update
    //   public Burger UpdateBurger(int id, Burger burger)
    //   {
    //     _db.ExecuteScalar<int>(@"
    // UPDATE Burgers SET 
    //  Name = @Name,
    //  Description = @Description,
    //  Price = @Price
    //  WHERE id = @id; 
    // SELECT LAST_INSERT_ID()", new
    //     {
    //       burger.Name,
    //       burger.Description,
    //       burger.Price,
    //       id
    //     });
    //     burger.id = id;
    //     return burger;
    //   }

    public bool DeleteBank(int id)
    {
      // int exe = _db.Execute($"DELETE FROM Keeps WHERE id = @id AND userId = @userId", new { id, userId });
      // return exe != 0;
      return true;
    }
  }
}