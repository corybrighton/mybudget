namespace mybudget.Models
{
  public class MonthAllotment
  {
    public int ID { get; set; }
    public string UserID { get; set; }
    public string CategoryItemID { get; set; }
    public decimal Budgeted { get; set; }
    public decimal Spent { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
  }
}