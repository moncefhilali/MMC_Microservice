using MediatR;
using MMC.Application.Interfaces;

namespace MMC.Application.Features.Mode.Commands;

public class ModeDeleteCmdHandler : IRequestHandler<ModeDeleteCmd, bool>
{
    private readonly IUnitOfService _service;
    public ModeDeleteCmdHandler(IUnitOfService service) => _service = service;




    public async Task<bool> Handle(ModeDeleteCmd request, CancellationToken cancellationToken)
    {
        bool success = await _service.ModeService.DeleteAsync(request.Id);
        return success;
    }
}