using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.GraphQL.Data
{
    //using primary constructor
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): DbContext(options)
    {
        public DbSet<Speaker> Speakers { get; init; }

        public DbSet<Attendee> Attendees { get; init;}

        public DbSet<Session> Sessions { get; init; }

        public DbSet<Track> Tracks {  get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureEntity();
        }

    }
}
