namespace MMC.Domain.DTOs;

public record ThemeGetDTO(int Id, string Name);
public record ThemePostDTO(string Name);
public record ThemePutDTO(int Id, string Name);