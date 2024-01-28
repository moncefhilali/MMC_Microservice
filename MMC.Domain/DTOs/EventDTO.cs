namespace MMC.Domain.DTOs;

public record EventGetDTO
(
    Guid Id,
    string Title,
    string? Address,
    string? Description,
    string? ImagePath,
    DateTime? StartDate,
    DateTime? EndDate,
    CityGetDTO City,
    ThemeGetDTO Theme
);

public record EventPostDTO
(
    string Title,
    string? Address,
    string? Description,
    string? ImagePath,
    DateTime? StartDate,
    DateTime? EndDate,
    int CityId,
    int ThemeId
);

public record EventPutDTO
(
    Guid Id,
    string Title,
    string? Address,
    string? Description,
    string? ImagePath,
    DateTime? StartDate,
    DateTime? EndDate,
    int CityId,
    int ThemeId
);