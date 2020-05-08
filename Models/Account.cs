using System;

namespace mybudget.Models
{
  public class Account
  {
    public int ID { get; set; }
    public bool IsLoan { get; set; }
    public string AccountType { get; set; }
    public int BankID { get; set; }
    public decimal Balance { get; set; }
    public decimal MonthlyPayment { get; set; }
    public string UserID { get; set; }
    public bool IsFlow { get; set; }
    public bool IncludedWorthStat { get; set; }
    public DateTime DeletedDate { get; set; }
  }
}