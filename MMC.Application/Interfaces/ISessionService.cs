using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface ISessionService
{
    Task<SessionGetDTO> FindAsync(Guid id);
    Task<IEnumerable<SessionGetDTO>> FindAllAsync();
    Task<SessionGetDTO> CreateAsync(SessionPostDTO sessionPostDTO);
    Task<SessionGetDTO> UpdateAsync(SessionPutDTO sessionPutDTO);
    Task<bool> DeleteAsync(Guid id);
}