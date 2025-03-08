using Microsoft.EntityFrameworkCore;

namespace Expense.Models;

public class SpendSmartDbContext:DbContext
{
    public DbSet<Expensenses> Expenses { get; set; }

    public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options):base(options){}

}