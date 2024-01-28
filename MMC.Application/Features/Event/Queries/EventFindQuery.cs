using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Event.Queries;

public record EventFindQuery(Guid Id) : IRequest<EventGetDTO>;