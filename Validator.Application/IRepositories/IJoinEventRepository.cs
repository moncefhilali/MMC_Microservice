using Validator.Domain.Entities;

namespace Validator.Application.IRepositories;

public interface IJoinEventRepository
{
    Task<IEnumerable<JoinEvent>> GetAllRequests();
    Task<bool> RequestJoinEvent(JoinEvent joinEvent);
    Task<bool> ApproveRequest(int id, JoinEvent joinEvent);
}