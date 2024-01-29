using MMC.Domain.Entities;

namespace MMC.Domain.DTOs;

public record SessionGetDTO
(
    Guid Id,
    string Name,
    int NumPlace,
    string? Description,
    DateTime? StartDate,
    DateTime? EndDate,
    Event Event,
    Mode Mode
);

public record SessionPostDTO
(
    string Name,
    int NumPlace,
    string? Description,
    DateTime? StartDate,
    DateTime? EndDate,
    Guid EventId,
    int ModeId
);

public record SessionPutDTO
(
    Guid Id,
    string Name,
    int NumPlace,
    string? Description,
    DateTime? StartDate,
    DateTime? EndDate,
    Guid EventId,
    int ModeId
);