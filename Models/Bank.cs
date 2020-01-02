using System.Collections.Generic;

namespace mybudget.Models
{
  public class BankDB
  {
    public int BankID { get; set; }
    public string Name { get; set; }
  }

  public class Bank
  {
    public string Name { get; set; }
    public List<Account> Accounts { get; set; }

    public decimal Total { get; set; }

    public decimal getTotal()
    {
      foreach (Account account in Accounts)
      {
        Total += account.Balance;
      }
      return Total;
    }
  }
}