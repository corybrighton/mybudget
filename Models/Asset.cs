using System;

namespace mybudget.Models
{
  public class Asset
  {
    public int ID { get; set; }
    public string AssetName { get; set; }
    public string UserID { get; set; }
    public decimal InitialValue { get; set; }
    public decimal CurrentValue { get; set; }
    public decimal InterestRate { get; set; }
    public bool IncludeWorthStat { get; set; }
    public DateTime DeletedDate { get; set; }
  }
}