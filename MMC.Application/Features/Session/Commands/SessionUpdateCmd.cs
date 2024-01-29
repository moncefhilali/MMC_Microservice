using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Session.Commands;

public record SessionUpdateCmd
(
    Guid Id,
    string Name,
    int NumPlace,
    string? Description,
    DateTime? StartDate,
    DateTime? EndDate,
    Guid EventId,
    int ModeId
) : IRequest<SessionGetDTO>;