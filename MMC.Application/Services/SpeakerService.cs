using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Services;

public class SpeakerService : ISpeakerService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public SpeakerService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<SpeakerGetDTO> FindAsync(Guid id)
    {
        var speaker = await _uow.SpeakerRepository.GetAsync(id);

        if (speaker is null) return null;

        return _map.Map<SpeakerGetDTO>(speaker);
    }
    public async Task<IEnumerable<SpeakerGetDTO>> FindAllAsync()
    {
        var speakers = await _uow.SpeakerRepository.GetAllAsync();

        if (speakers is null) return null;

        return _map.Map<IEnumerable<SpeakerGetDTO>>(speakers);
    }
    public async Task<SpeakerGetDTO> CreateAsync(SpeakerPostDTO speakerPostDTO)
    {
        var speaker = _map.Map<Speaker>(speakerPostDTO);
        if (!await _uow.SpeakerRepository.PostAsync(speaker))
            return null;

        await _uow.CompleteAsync();
        return _map.Map<SpeakerGetDTO>(speaker);
    }
    public async Task<SpeakerGetDTO> UpdateAsync(SpeakerPutDTO speakerPutDTO)
    {
        var speaker = _map.Map<Speaker>(speakerPutDTO);
        var updatedSpeaker = await _uow.SpeakerRepository.PutAsync(speaker.Id, speaker);

        await _uow.CompleteAsync();
        return _map.Map<SpeakerGetDTO>(updatedSpeaker);
    }
    public async Task<bool> DeleteAsync(Guid id)
    {
        var success = await _uow.SpeakerRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}