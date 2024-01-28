using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Event.Queries;

public record EventFindAllQuery : IRequest<IEnumerable<EventGetDTO>>;