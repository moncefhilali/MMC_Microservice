namespace MMC.Domain.DTOs;

public record UserGetDTO(Guid Id, string Username, string Email, string Password);