using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTrackerApp.Data
{
    public class ExpensesTrackerAppContext : DbContext
    {
        public ExpensesTrackerAppContext (DbContextOptions<ExpensesTrackerAppContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expense { get; set; } = default!;
    }
}
