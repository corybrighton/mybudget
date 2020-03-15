using System;

namespace mybudget.Models
{
  public class Transaction
  {
    public int ID { get; set; }
    public int MonthAllotmentID { get; set; }
    public decimal Amount { get; set; }
    public string Payee { get; set; }
    public string UserID { get; set; }
    public int AccountID { get; set; }
    public bool Cleared { get; set; }
    public DateTime Date { get; set; }
  }
}