using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface IUserService
{
    Task<UserGetDTO> FindAsync(Guid id);
    Task<IEnumerable<UserGetDTO>> FindAllAsync();
    Task<bool> DeleteAsync(Guid id);
}