using System.ComponentModel.DataAnnotations;

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
    public ExpenseCategory Category { get; set; } // e.g., Food, Utilities, Travel

    [Required]
    [Range(0.01, 1000000)]
    public decimal Amount { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [StringLength(300)]
    public string Description { get; set; }

}
