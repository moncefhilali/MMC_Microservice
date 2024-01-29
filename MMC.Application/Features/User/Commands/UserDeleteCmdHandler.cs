using MediatR;
using MMC.Application.Features.Sponsor.Commands;
using MMC.Application.Interfaces;

namespace MMC.Application.Features.User.Commands;

public class UserDeleteCmdHandler : IRequestHandler<UserDeleteCmd, bool>
{
    private readonly IUnitOfService _service;
    public UserDeleteCmdHandler(IUnitOfService service) => _service = service;




    public async Task<bool> Handle(UserDeleteCmd request, CancellationToken cancellationToken)
    {
        bool success = await _service.UserService.DeleteAsync(request.Id);
        return success;
    }
}