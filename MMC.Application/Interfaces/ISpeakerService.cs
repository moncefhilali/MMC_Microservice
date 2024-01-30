using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface ISpeakerService
{
    Task<SpeakerGetDTO> FindAsync(Guid id);
    Task<IEnumerable<SpeakerGetDTO>> FindAllAsync();
    Task<SpeakerGetDTO> CreateAsync(SpeakerPostDTO speakerPostDTO);
    Task<SpeakerGetDTO> UpdateAsync(SpeakerPutDTO speakerPutDTO);
    Task<bool> DeleteAsync(Guid id);
}