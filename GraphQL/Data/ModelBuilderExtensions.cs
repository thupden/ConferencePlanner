using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.GraphQL.Data
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigureEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Attendee>()
            .HasIndex(a => a.Username)
            .IsUnique();

            // Many-to-many: Session <-> Attendee
            modelBuilder
                .Entity<SessionAttendee>()
                .HasKey(sa => new { sa.SessionId, sa.AttendeeId });

            // Many-to-many: Speaker <-> Session
            modelBuilder
                .Entity<SessionSpeaker>()
                .HasKey(ss => new { ss.SessionId, ss.SpeakerId });
        }
    }
}
