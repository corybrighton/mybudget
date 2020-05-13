using System;

namespace mybudget.Models
{
  public class EnvelopeAllotment
  {
    public int ID { get; set; }
    public int BudgetID { get; set; }
    public int EnvelopeID { get; set; }
    public String UserID { get; set; }
    public int CreatedMonth { get; set; }
    public int CreatedYear { get; set; }
    public decimal Budgeted { get; set; }
    public decimal Spent { get; set; }
    public decimal Cleared { get; set; }
    public DateTime DeletedDate { get; set; }
  }
}