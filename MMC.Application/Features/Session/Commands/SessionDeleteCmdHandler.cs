using MediatR;
using MMC.Application.Interfaces;

namespace MMC.Application.Features.Session.Commands;

public class SessionDeleteCmdHandler : IRequestHandler<SessionDeleteCmd, bool>
{
    private readonly IUnitOfService _service;
    public SessionDeleteCmdHandler(IUnitOfService service) => _service = service;




    public async Task<bool> Handle(SessionDeleteCmd request, CancellationToken cancellationToken)
    {
        bool success = await _service.SessionService.DeleteAsync(request.Id);
        return success;
    }
}