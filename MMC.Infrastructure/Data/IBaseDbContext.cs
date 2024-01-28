using MMC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MMC.Infrastructure.Data;

public interface IBaseDbContext
{
    DbSet<City> Cities { get; set; }
    DbSet<Event> Events { get; set; }
    DbSet<EventPartner> EventPartners { get; set; }
    DbSet<Mode> Modes { get; set; }
    DbSet<Participant> Participants { get; set; }
    DbSet<Partner> Partners { get; set; }
    DbSet<Role> Roles { get; set; }
    DbSet<Session> Sessions { get; set; }
    DbSet<SessionParticipant> SessionParticipants { get; set; }
    DbSet<SessionSponsor> SessionSponsors { get; set; }
    DbSet<SessionSpeaker> SessionSpeakers { get; set; }
    DbSet<Speaker> Speakers { get; set; }
    DbSet<Sponsor> Sponsors { get; set; }
    DbSet<Theme> Themes { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<UserRole> UserRoles { get; set; }
    DbSet<T> Set<T>() where T : class;

    Task<int> SaveChangesAsync();
}