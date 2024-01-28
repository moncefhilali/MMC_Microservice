using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface IPartnerService
{
    Task<PartnerGetDTO> FindAsync(Guid id);
    Task<IEnumerable<PartnerGetDTO>> FindAllAsync();
    Task<PartnerGetDTO> CreateAsync(PartnerPostDTO partnerPostDTO);
    Task<PartnerGetDTO> UpdateAsync(PartnerPutDTO partnerPutDTO);
    Task<bool> DeleteAsync(Guid id);
}