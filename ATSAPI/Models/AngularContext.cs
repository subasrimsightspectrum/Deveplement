namespace WebApiCoreWithEF.Context
{
    using Microsoft.EntityFrameworkCore;
    using WebApiCoreWithEF.Models;

    public class AngularContext
        : DbContext
    {
        public AngularContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserDetails> Users { get; set; }
    }
}
