namespace mybudget.Models
{
  public class Account
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int BankID { get; set; }
    public decimal Uncleared { get; set; }
    public decimal Balance { get; set; }
    public string UserID { get; set; }
  }
}