using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.User.Queries;

public class UserFindQueryHandler : IRequestHandler<UserFindQuery, UserGetDTO>
{
    private readonly IUnitOfService _service;
    public UserFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<UserGetDTO> Handle(UserFindQuery request, CancellationToken cancellationToken)
    {
        var user = await _service.UserService.FindAsync(request.Id);
        return user;
    }
}