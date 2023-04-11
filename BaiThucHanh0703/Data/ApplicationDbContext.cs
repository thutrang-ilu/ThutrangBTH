using BaiThucHanh0703.Models;
using Microsoft.EntityFrameworkCore;
namespace BaiThucHanh0703.Data;

    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Employee> Employee { get; set; }
        public DbSet<BaiThucHanh0703.Models.Person> Person { get; set; } = default!;

    }
