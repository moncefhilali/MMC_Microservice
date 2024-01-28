using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.City.Commands;

public class CityUpdateCmdHandler : IRequestHandler<CityUpdateCmd, CityGetDTO>
{
    private readonly IUnitOfService _service;
    public CityUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<CityGetDTO> Handle(CityUpdateCmd request, CancellationToken cancellationToken)
    {
        var cityPutDTO = new CityPutDTO(request.Id, request.Name);
        var city = await _service.CityService.UpdateAsync(cityPutDTO);
        return city;
    }
}