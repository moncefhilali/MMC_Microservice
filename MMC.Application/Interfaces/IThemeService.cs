using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface IThemeService
{
    Task<ThemeGetDTO> FindAsync(int id);
    Task<IEnumerable<ThemeGetDTO>> FindAllAsync();
    Task<ThemeGetDTO> CreateAsync(ThemePostDTO themePostDTO);
    Task<ThemeGetDTO> UpdateAsync(ThemePutDTO themePutDTO);
    Task<bool> DeleteAsync(int id);
}