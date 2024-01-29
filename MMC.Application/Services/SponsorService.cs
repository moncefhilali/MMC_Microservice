using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Services;

public class SponsorService : ISponsorService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public SponsorService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<SponsorGetDTO> FindAsync(Guid id)
    {
        var sponsor = await _uow.SponsorRepository.GetAsync(id);

        if (sponsor is null) return null;

        return _map.Map<SponsorGetDTO>(sponsor);
    }
    public async Task<IEnumerable<SponsorGetDTO>> FindAllAsync()
    {
        var sponsors = await _uow.SponsorRepository.GetAllAsync();

        if (sponsors is null) return null;

        return _map.Map<IEnumerable<SponsorGetDTO>>(sponsors);
    }
    public async Task<SponsorGetDTO> CreateAsync(SponsorPostDTO sponsorPostDTO)
    {
        var sponsor = _map.Map<Sponsor>(sponsorPostDTO);
        if (!await _uow.SponsorRepository.PostAsync(sponsor))
            return null;

        await _uow.CompleteAsync();
        return _map.Map<SponsorGetDTO>(sponsor);
    }
    public async Task<SponsorGetDTO> UpdateAsync(SponsorPutDTO sponsorPutDTO)
    {
        var sponsor = _map.Map<Sponsor>(sponsorPutDTO);
        var updatedSponsor = await _uow.SponsorRepository.PutAsync(sponsor.Id, sponsor);

        await _uow.CompleteAsync();
        return _map.Map<SponsorGetDTO>(updatedSponsor);
    }
    public async Task<bool> DeleteAsync(Guid id)
    {
        var success = await _uow.SponsorRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}