namespace MMC.Domain.DTOs;

public record ModeGetDTO(int Id, string Name);
public record ModePostDTO(string Name);
public record ModePutDTO(int Id, string Name);