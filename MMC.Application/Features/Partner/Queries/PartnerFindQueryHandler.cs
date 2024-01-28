using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Partner.Queries;

public class PartnerFindQueryHandler : IRequestHandler<PartnerFindQuery, PartnerGetDTO>
{
    private readonly IUnitOfService _service;
    public PartnerFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<PartnerGetDTO> Handle(PartnerFindQuery request, CancellationToken cancellationToken)
    {
        var partner = await _service.PartnerService.FindAsync(request.Id);
        return partner;
    }
}