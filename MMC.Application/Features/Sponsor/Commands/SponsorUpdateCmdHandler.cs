using MediatR;
using MMC.Application.Features.Partner.Commands;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Sponsor.Commands;

public class SponsorUpdateCmdHandler : IRequestHandler<SponsorUpdateCmd, SponsorGetDTO>
{
    private readonly IUnitOfService _service;
    public SponsorUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<SponsorGetDTO> Handle(SponsorUpdateCmd request, CancellationToken cancellationToken)
    {
        var sponsorPutDTO = new SponsorPutDTO(request.Id, request.Name, request.Description, request.LogoPath);
        var sponsor = await _service.SponsorService.UpdateAsync(sponsorPutDTO);
        return sponsor;
    }
}