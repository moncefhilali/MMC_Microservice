using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.City.Commands;

public class CityCreateCmdHandler : IRequestHandler<CityCreateCmd, CityGetDTO>
{
    private readonly IUnitOfService _service;
    public CityCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<CityGetDTO> Handle(CityCreateCmd request, CancellationToken cancellationToken)
    {
        var cityPostDTO = new CityPostDTO(request.Name);
        var city = await _service.CityService.CreateAsync(cityPostDTO);
        return city;
    }
}