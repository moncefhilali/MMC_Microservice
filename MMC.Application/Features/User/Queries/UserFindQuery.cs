using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.User.Queries;

public record UserFindQuery(Guid Id) : IRequest<UserGetDTO>;