using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.User.Queries;

public record UserFindAllQuery : IRequest<IEnumerable<UserGetDTO>>;