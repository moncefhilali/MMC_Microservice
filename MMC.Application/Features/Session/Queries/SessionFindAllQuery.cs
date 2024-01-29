using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Session.Queries;

public record SessionFindAllQuery : IRequest<IEnumerable<SessionGetDTO>>;