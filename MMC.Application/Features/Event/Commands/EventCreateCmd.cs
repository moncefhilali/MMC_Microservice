using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Event.Commands;

public record EventCreateCmd
(
    string Title,
    string? Address,
    string? Description,
    string? ImagePath,
    DateTime? StartDate,
    DateTime? EndDate,
    int CityId,
    int ThemeId
) : IRequest<EventGetDTO>;