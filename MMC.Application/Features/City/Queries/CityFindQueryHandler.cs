using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.City.Queries;

public class CityFindQueryHandler : IRequestHandler<CityFindQuery, CityGetDTO>
{
    private readonly IUnitOfService _service;
    public CityFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<CityGetDTO> Handle(CityFindQuery request, CancellationToken cancellationToken)
    {
        var city = await _service.CityService.FindAsync(request.Id);
        return city;
    }
}