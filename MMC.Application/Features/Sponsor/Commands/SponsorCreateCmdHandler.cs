using MediatR;
using MMC.Application.Features.Partner.Commands;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Sponsor.Commands;

public class SponsorCreateCmdHandler : IRequestHandler<SponsorCreateCmd, SponsorGetDTO>
{
    private readonly IUnitOfService _service;
    public SponsorCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<SponsorGetDTO> Handle(SponsorCreateCmd request, CancellationToken cancellationToken)
    {
        var sponsorPostDTO = new SponsorPostDTO(request.Name, request.Description, request.LogoPath);
        var sponsor = await _service.SponsorService.CreateAsync(sponsorPostDTO);
        return sponsor;
    }
}