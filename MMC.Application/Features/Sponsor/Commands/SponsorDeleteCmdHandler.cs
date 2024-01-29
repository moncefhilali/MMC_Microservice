using MediatR;
using MMC.Application.Features.Partner.Commands;
using MMC.Application.Interfaces;

namespace MMC.Application.Features.Sponsor.Commands;

public class SponsorDeleteCmdHandler : IRequestHandler<SponsorDeleteCmd, bool>
{
    private readonly IUnitOfService _service;
    public SponsorDeleteCmdHandler(IUnitOfService service) => _service = service;




    public async Task<bool> Handle(SponsorDeleteCmd request, CancellationToken cancellationToken)
    {
        bool success = await _service.SponsorService.DeleteAsync(request.Id);
        return success;
    }
}