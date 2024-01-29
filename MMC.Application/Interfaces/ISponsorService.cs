using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface ISponsorService
{
    Task<SponsorGetDTO> FindAsync(Guid id);
    Task<IEnumerable<SponsorGetDTO>> FindAllAsync();
    Task<SponsorGetDTO> CreateAsync(SponsorPostDTO sponsorPostDTO);
    Task<SponsorGetDTO> UpdateAsync(SponsorPutDTO sponsorPutDTO);
    Task<bool> DeleteAsync(Guid id);
}