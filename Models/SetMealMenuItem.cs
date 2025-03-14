using System.ComponentModel.DataAnnotations;

public class SetMealMenuItem
{
  [Key]
  public int Id { get; set; }

  [Required]
  public int SetMealId { get; set; }
  public SetMeal? SetMeal { get; set; }

  [Required]
  public int MenuItemId { get; set; }
  public MenuItem? MenuItem { get; set; }
}
