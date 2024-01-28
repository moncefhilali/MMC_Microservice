using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Partner.Queries;

public class PartnerFindAllQueryHandler : IRequestHandler<PartnerFindAllQuery, IEnumerable<PartnerGetDTO>>
{
    private readonly IUnitOfService _service;
    public PartnerFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<PartnerGetDTO>> Handle(PartnerFindAllQuery request, CancellationToken cancellationToken)
    {
        var partners = await _service.PartnerService.FindAllAsync();
        return partners;
    }
}