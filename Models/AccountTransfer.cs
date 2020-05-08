using System;

namespace mybudget.Models
{
  public class AccountTransfer
  {
    public int AccountID { get; set; }
    public int ID { get; set; }
    public int ToAccountID { get; set; }
    public String UserID { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransferDate { get; set; }
    public bool Cleared { get; set; }
    public bool IsReaquiring { get; set; }
    public DateTime DeletedDate { get; set; }
  }
}