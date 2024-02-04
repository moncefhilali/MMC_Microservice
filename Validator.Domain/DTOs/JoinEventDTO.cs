namespace Validator.Domain.DTOs;

public record JoinEventGetDTO(int Id, int ParticipantId, int EventId, DateTime ParticipationDate, bool IsApproved);
public record JoinEventPostDTO(int ParticipantId, int EventId);
public record JoinEventPutDTO(int Id, int ParticipantId, int EventId, DateTime ParticipationDate, bool IsApproved);