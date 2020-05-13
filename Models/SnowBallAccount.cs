using System;

namespace mybudget.Models
{
  class SnowBallAccount
  {
    public int ID { get; set; }
    public String UserID { get; set; }
    public int AccountID { get; set; }
    public decimal MonthlyMinPay { get; set; }
    public decimal IntialValue { get; set; }
    public DateTime CreateDate { get; set; }
  }
}