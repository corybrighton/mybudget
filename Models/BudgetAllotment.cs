using System;

namespace mybudget.Models
{
  public class BudgetAllotment
  {
    public int ID { get; set; }
    public int BudgetID { get; set; }
    public String UserID { get; set; }
    public int CreatedMonth { get; set; }
    public int CreatedYear { get; set; }
    public decimal Budgeted { get; set; }
    public decimal Spent { get; set; }
    public decimal Cleared { get; set; }
    public decimal Average { get; set; }
    public DateTime DeletedDate { get; set; }
  }
}
