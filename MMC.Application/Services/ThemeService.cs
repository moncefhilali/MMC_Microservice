using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Services;

public class ThemeService : IThemeService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public ThemeService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<ThemeGetDTO> FindAsync(int id)
    {
        var theme = await _uow.ThemeRepository.GetAsync(id);

        if (theme is null) return null;

        return _map.Map<ThemeGetDTO>(theme);
    }
    public async Task<IEnumerable<ThemeGetDTO>> FindAllAsync()
    {
        var themes = await _uow.ThemeRepository.GetAllAsync();

        if (themes is null) return null;

        return _map.Map<IEnumerable<ThemeGetDTO>>(themes);
    }
    public async Task<ThemeGetDTO> CreateAsync(ThemePostDTO themePostDTO)
    {
        var theme = _map.Map<Theme>(themePostDTO);
        if (!await _uow.ThemeRepository.PostAsync(theme))
            return null;

        await _uow.CompleteAsync();
        return _map.Map<ThemeGetDTO>(theme);
    }
    public async Task<ThemeGetDTO> UpdateAsync(ThemePutDTO themePutDTO)
    {
        var theme = _map.Map<Theme>(themePutDTO);
        var updatedTheme = await _uow.ThemeRepository.PutAsync(theme.Id, theme);

        await _uow.CompleteAsync();
        return _map.Map<ThemeGetDTO>(updatedTheme);
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var success = await _uow.ThemeRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}