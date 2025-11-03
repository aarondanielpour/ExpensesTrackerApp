using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public enum ExpenseCategory
{
    Food,
    Transportation,
    Utilities,
    Housing,
    Healthcare,
    Entertainment,
    Education,
    Miscellaneous
}

public class Expense
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Expense Category")]
    public ExpenseCategory Category { get; set; } // e.g., Food, Utilities, Travel

    [Required]
    [Range(0.01, 1000000)]
    [Precision(18,2)]
    public decimal Amount { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; } = DateTime.Now;

    [StringLength(300)]
    public string? Description { get; set; }

}
