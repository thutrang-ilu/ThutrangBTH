using Microsoft.EntityFrameworkCore;
using BTH1004.Models;
namespace BTH1004.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<BTH1004.Models.Person> Person { get; set; } = default!;
        public DbSet<BTH1004.Models.Student> Student { get; set; } = default!;
        public DbSet<BTH1004.Models.Employee> Employee { get; set; } = default!;
        public DbSet<BTH1004.Models.Customer> Customer { get; set; } = default!;
  
    }
