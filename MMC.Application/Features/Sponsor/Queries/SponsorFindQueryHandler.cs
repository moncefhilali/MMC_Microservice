using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Sponsor.Queries;

public class SponsorFindQueryHandler : IRequestHandler<SponsorFindQuery, SponsorGetDTO>
{
    private readonly IUnitOfService _service;
    public SponsorFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<SponsorGetDTO> Handle(SponsorFindQuery request, CancellationToken cancellationToken)
    {
        var sponsor = await _service.SponsorService.FindAsync(request.Id);
        return sponsor;
    }
}