using System;

namespace mybudget.Models
{
  public class SnowBall
  {
    public int ID { get; set; }
    public String UserID { get; set; }
    public decimal Planned { get; set; }
    public decimal MonthlyPay { get; set; }
    public decimal ExtraPay { get; set; }
  }
}