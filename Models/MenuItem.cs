using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public enum CategoryType
{
  Mains,
  Starters,
  Desserts,
  Drinks
}

public enum SaleStatus
{
  OnSale,
  OutOfStock
}

public class MenuItem
{
  [Key]
  public int Id { get; set; }

  [Required]
  public required string Name { get; set; }

  [Required]
  public CategoryType Category { get; set; }

  [Required]
  [Column(TypeName = "decimal(10,2)")]
  public decimal Price { get; set; }

  [Required]
  public SaleStatus Status { get; set; }

  public ICollection<SetMealMenuItem>? SetMealMenuItems { get; set; }
}
