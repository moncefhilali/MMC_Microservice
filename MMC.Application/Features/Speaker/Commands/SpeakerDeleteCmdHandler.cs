using MediatR;
using MMC.Application.Interfaces;

namespace MMC.Application.Features.Speaker.Commands;

public class SpeakerDeleteCmdHandler : IRequestHandler<SpeakerDeleteCmd, bool>
{
    private readonly IUnitOfService _service;
    public SpeakerDeleteCmdHandler(IUnitOfService service) => _service = service;




    public async Task<bool> Handle(SpeakerDeleteCmd request, CancellationToken cancellationToken)
    {
        bool success = await _service.SpeakerService.DeleteAsync(request.Id);
        return success;
    }
}