using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Sponsor.Queries;

public class SponsorFindAllQueryHandler : IRequestHandler<SponsorFindAllQuery, IEnumerable<SponsorGetDTO>>
{
    private readonly IUnitOfService _service;
    public SponsorFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<SponsorGetDTO>> Handle(SponsorFindAllQuery request, CancellationToken cancellationToken)
    {
        var sponsors = await _service.SponsorService.FindAllAsync();
        return sponsors;
    }
}