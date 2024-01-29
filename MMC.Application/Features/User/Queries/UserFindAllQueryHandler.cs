using MediatR;
using MMC.Application.Features.Sponsor.Queries;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.User.Queries;

public class UserFindAllQueryHandler : IRequestHandler<UserFindAllQuery, IEnumerable<UserGetDTO>>
{
    private readonly IUnitOfService _service;
    public UserFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<UserGetDTO>> Handle(UserFindAllQuery request, CancellationToken cancellationToken)
    {
        var users = await _service.UserService.FindAllAsync();
        return users;
    }
}