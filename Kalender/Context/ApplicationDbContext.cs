using Kalender.Data;
using Microsoft.EntityFrameworkCore;

namespace Kalender.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
