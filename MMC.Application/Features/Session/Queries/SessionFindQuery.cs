using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Session.Queries;

public record SessionFindQuery(Guid Id) : IRequest<SessionGetDTO>;