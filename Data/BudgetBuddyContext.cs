using Microsoft.EntityFrameworkCore;
using BudgetBuddy.Data.Models;

namespace BudgetBuddy.Data
{
    public class BudgetBuddyContext :DbContext
	{
		public BudgetBuddyContext(DbContextOptions<BudgetBuddyContext> options) 
			: base(options) 
		{
		}

		public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
		public DbSet<Income> Incomes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
				.HasData(new Category[]
				{
					new Category { Id = 1,Name = "Food"},
					new Category { Id = 2,Name = "Travel"},
					new Category { Id = 3,Name = "Entertainment"},
					new Category { Id = 4,Name = "Education"},
					new Category { Id = 5,Name = "Clothes"},
					new Category { Id = 6,Name = "House"},
				});
		}
	}
}