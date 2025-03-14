using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SetMeal
{
  [Key]
  public int Id { get; set; }

  [Required]
  public string? Name { get; set; }

  [Required]
  [Column(TypeName = "decimal(10,2)")]
  public decimal Price { get; set; }

  [Required]
  public SaleStatus Status { get; set; }

  public ICollection<SetMealMenuItem>? SetMealMenuItems { get; set; }
}
