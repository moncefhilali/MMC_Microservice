using Microsoft.EntityFrameworkCore;
using MMC.Domain.Entities;

namespace MMC.Infrastructure.Data;

public class BaseDbContext : DbContext, IBaseDbContext
{
    public BaseDbContext(DbContextOptions options) : base(options) { }

    public DbSet<City> Cities { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventPartner> EventPartners { get; set; }
    public DbSet<Mode> Modes { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Partner> Partners { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<SessionParticipant> SessionParticipants { get; set; }
    public DbSet<SessionSponsor> SessionSponsors { get; set; }
    public DbSet<SessionSpeaker> SessionSpeakers { get; set; }
    public DbSet<Speaker> Speakers { get; set; }
    public DbSet<Sponsor> Sponsors { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public new DbSet<T> Set<T>() where T : class => base.Set<T>();


    public async Task<int> SaveChangesAsync()
        => await base.SaveChangesAsync();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EventPartner>()
            .HasKey(ep => new { ep.EventId, ep.PartnerId });

        modelBuilder.Entity<SessionParticipant>()
            .HasKey(sp => new { sp.SessionId, sp.ParticipantId });

        modelBuilder.Entity<SessionSpeaker>()
            .HasKey(ss => new { ss.SessionId, ss.SpeakerId });

        modelBuilder.Entity<SessionSponsor>()
            .HasKey(sp => new { sp.SessionId, sp.SponsorId });

        modelBuilder.Entity<UserRole>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });

        // Add the following lines to set Restrict behavior
        modelBuilder.Entity<SessionParticipant>()
            .HasOne(sp => sp.Session)
            .WithMany(s => s.SessionParticipants)
            .HasForeignKey(sp => sp.SessionId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<SessionSpeaker>()
            .HasOne(ss => ss.Session)
            .WithMany(s => s.SessionSpeakers)
            .HasForeignKey(ss => ss.SessionId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<SessionSponsor>()
            .HasOne(sp => sp.Session)
            .WithMany(s => s.SessionSponsors)
            .HasForeignKey(sp => sp.SessionId)
            .OnDelete(DeleteBehavior.Restrict);

        // ... other configurations, if any

        base.OnModelCreating(modelBuilder);
    }

}