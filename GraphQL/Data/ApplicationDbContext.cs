using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.GraphQL.Data
{
    //using primary constructor
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): DbContext(options)
    {
       public DbSet<Speaker> Speakers { get; init; }

    }
}
