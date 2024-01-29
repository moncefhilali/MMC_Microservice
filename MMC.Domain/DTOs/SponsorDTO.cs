namespace MMC.Domain.DTOs;

public record SponsorGetDTO(Guid Id, string Name, string? Description, string? LogoPath);
public record SponsorPostDTO(string Name, string? Description, string? LogoPath);
public record SponsorPutDTO(Guid Id, string Name, string? Description, string? LogoPath);