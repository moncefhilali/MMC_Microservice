using Validator.Domain.DTOs;

namespace Validator.Application.Interfaces;

public interface IJoinEventService
{
    Task<IEnumerable<JoinEventGetDTO>> GetAllRequests();
    Task<bool> RequestJoinEvent(JoinEventPostDTO joinEventPostDTO);
    Task<bool> ApproveRequest(JoinEventPutDTO joinEventPutDTO);
}