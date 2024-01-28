using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Services;

public class ModeService : IModeService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public ModeService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<ModeGetDTO> FindAsync(int id)
    {
        var mode = await _uow.ModeRepository.GetAsync(id);

        if (mode is null) return null;

        return _map.Map<ModeGetDTO>(mode);
    }
    public async Task<IEnumerable<ModeGetDTO>> FindAllAsync()
    {
        var modes = await _uow.ModeRepository.GetAllAsync();

        if (modes is null) return null;

        return _map.Map<IEnumerable<ModeGetDTO>>(modes);
    }
    public async Task<ModeGetDTO> CreateAsync(ModePostDTO modePostDTO)
    {
        var mode = _map.Map<Mode>(modePostDTO);
        if (!await _uow.ModeRepository.PostAsync(mode))
            return null;

        await _uow.CompleteAsync();
        return _map.Map<ModeGetDTO>(mode);
    }
    public async Task<ModeGetDTO> UpdateAsync(ModePutDTO modePutDTO)
    {
        var mode = _map.Map<Mode>(modePutDTO);
        var updatedMode = await _uow.ModeRepository.PutAsync(mode.Id, mode);

        await _uow.CompleteAsync();
        return _map.Map<ModeGetDTO>(updatedMode);
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var success = await _uow.ModeRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}