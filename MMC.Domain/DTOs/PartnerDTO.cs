namespace MMC.Domain.DTOs;

public record PartnerGetDTO(Guid Id, string Name, string? Description, string? LogoPath);
public record PartnerPostDTO(string Name, string? Description, string? LogoPath);
public record PartnerPutDTO(Guid Id, string Name, string? Description, string? LogoPath);