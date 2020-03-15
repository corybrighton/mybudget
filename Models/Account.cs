namespace mybudget.Models
{
  public class Account
  {
    public int ID { get; set; }
    public bool IsLoan { get; set; }
    public string Type { get; set; }
    public int BankID { get; set; }
    public decimal Balance { get; set; }
    public string UserID { get; set; }
    public bool IncludeWorthStat { get; set; }
  }
}