using Database.Addresses;
using Database.People;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class AppDatabase : DbContext
    {
        public AppDatabase(string dbConnection) : base(CreateDbContext(dbConnection))
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OtherName> OtherNames { get; set; }

        public static DbContextOptions<AppDatabase> CreateDbContext(string connection)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDatabase>();
            optionsBuilder.UseSqlServer(connection);
            return optionsBuilder.Options;
        }
    }
}
