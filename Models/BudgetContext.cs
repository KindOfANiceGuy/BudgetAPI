using Microsoft.EntityFrameworkCore;

namespace BudgetApi.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) {}

        public DbSet<Expense> Expenses {get; set;}
        public DbSet<SubCategory> SubCategories {get; set;}
    }
}