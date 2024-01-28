using MMC.Domain.DTOs;

namespace MMC.Application.Interfaces;

public interface ICityService
{
    Task<CityGetDTO> FindAsync(int id);
    Task<IEnumerable<CityGetDTO>> FindAllAsync();
    Task<CityGetDTO> CreateAsync(CityPostDTO cityPostDTO);
    Task<CityGetDTO> UpdateAsync(CityPutDTO cityPutDTO);
    Task<bool> DeleteAsync(int id);
}