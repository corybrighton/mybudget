using mybudget.Models;
using System.Collections.Generic;

namespace mybudget.Repositories
{
  public class AccountsRepository
  {
    // private readonly IDbConnection _db;
    // public AccountsRepository(IDbConnection db)
    // {
    //   _db = db;
    // }

    IEnumerable<Bank> tempdata()
    {
      Account account = new Account()
      {
        Balance = 15.75M,
        BankID = 1,
        ID = 1,
        Name = "Savings",
        Uncleared = 0.23M,
        UserID = "user"
      };
      Account account1 = new Account()
      {
        Balance = 13.75M,
        BankID = 1,
        ID = 1,
        Name = "Checking",
        Uncleared = 1.23M,
        UserID = "user"
      };
      Account account2 = new Account()
      {
        Balance = 41.55M,
        BankID = 2,
        ID = 1,
        Name = "Savings",
        Uncleared = 2.23M,
        UserID = "user"
      };
      Bank bank1 = new Bank()
      {
        Name = "Wells Fargo",
      };
      Bank bank2 = new Bank()
      {
        Name = "Credit Union"
      };
      bank1.Accounts = new List<Account>();
      bank1.Accounts.Add(account);
      bank1.Accounts.Add(account1);
      bank1.Total = bank1.getTotal();
      bank2.Accounts = new List<Account>();
      bank2.Accounts.Add(account2);
      bank2.Total = bank2.getTotal();

      List<Bank> Banks = new List<Bank>();
      Banks.Add(bank1);
      Banks.Add(bank2);

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