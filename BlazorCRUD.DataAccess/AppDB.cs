using BlazorCRUD.DomainObjects;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.DataAccess
{
    public class AppDB : DbContext
    {
        public AppDB(DbContextOptions<AppDB> contextOptions) : base(contextOptions)
        {
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
