using System.ComponentModel.DataAnnotations;

namespace Expense.Models;

public class Expensenses
{
    public int Id { get; set; }

    public decimal Value { get; set; }

    [Required]
    public string? Description { get; set; }
}
