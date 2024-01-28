using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface IModeService
{
    Task<ModeGetDTO> FindAsync(int id);
    Task<IEnumerable<ModeGetDTO>> FindAllAsync();
    Task<ModeGetDTO> CreateAsync(ModePostDTO modePostDTO);
    Task<ModeGetDTO> UpdateAsync(ModePutDTO modePutDTO);
    Task<bool> DeleteAsync(int id);
}