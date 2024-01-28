using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface IEventService
{
    Task<EventGetDTO> FindAsync(Guid id);
    Task<IEnumerable<EventGetDTO>> FindAllAsync();
    Task<EventGetDTO> CreateAsync(EventPostDTO eventPostDTO);
    Task<EventGetDTO> UpdateAsync(EventPutDTO eventPutDTO);
    Task<bool> DeleteAsync(Guid id);
}