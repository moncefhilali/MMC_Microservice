using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMC.Application.Services;

public class PartnerService : IPartnerService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public PartnerService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<PartnerGetDTO> FindAsync(Guid id)
    {
        var partner = await _uow.PartnerRepository.GetAsync(id);

        if (partner is null) return null;

        return _map.Map<PartnerGetDTO>(partner);
    }
    public async Task<IEnumerable<PartnerGetDTO>> FindAllAsync()
    {
        var partners = await _uow.PartnerRepository.GetAllAsync();

        if (partners is null) return null;

        return _map.Map<IEnumerable<PartnerGetDTO>>(partners);
    }
    public async Task<PartnerGetDTO> CreateAsync(PartnerPostDTO partnerPostDTO)
    {
        var partner = _map.Map<Partner>(partnerPostDTO);
        if (!await _uow.PartnerRepository.PostAsync(partner))
            return null;

        await _uow.CompleteAsync();
        return _map.Map<PartnerGetDTO>(partner);
    }
    public async Task<PartnerGetDTO> UpdateAsync(PartnerPutDTO partnerPutDTO)
    {
        var partner = _map.Map<Partner>(partnerPutDTO);
        var updatedPartner = await _uow.PartnerRepository.PutAsync(partner.Id, partner);

        await _uow.CompleteAsync();
        return _map.Map<PartnerGetDTO>(updatedPartner);
    }
    public async Task<bool> DeleteAsync(Guid id)
    {
        var success = await _uow.PartnerRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}