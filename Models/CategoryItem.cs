namespace mybudget.Models
{
  public class CategoryItem
  {
    public int ID { get; set; }
    public string CategoryID { get; set; }
    public string Item { get; set; }
    public bool IsSaving { get; set; }
  }
}