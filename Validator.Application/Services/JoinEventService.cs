using AutoMapper;
using Validator.Application.Interfaces;
using Validator.Application.IRepositories;
using Validator.Domain.DTOs;
using Validator.Domain.Entities;

namespace Validator.Application.Services;

public class JoinEventService : IJoinEventService
{
    private readonly IJoinEventRepository _repo;
    private readonly IMapper _map;
    public JoinEventService(IJoinEventRepository repo, IMapper map)
    {
        _repo = repo;
        _map = map;
    }




    public async Task<IEnumerable<JoinEventGetDTO>> GetAllRequests()
    {
        var requests = await _repo.GetAllRequests();

        if (requests is null) return null;

        return _map.Map<IEnumerable<JoinEventGetDTO>>(requests);
    }
    public async Task<bool> RequestJoinEvent(JoinEventPostDTO joinEventPostDTO)
    {
        var request = _map.Map<JoinEvent>(joinEventPostDTO);
        if (!await _repo.RequestJoinEvent(request))
            return false;

        return true;
    }
    public async Task<bool> ApproveRequest(JoinEventPutDTO joinEventPutDTO)
    {
        var request = _map.Map<JoinEvent>(joinEventPutDTO);
        var updatedRequest = await _repo.ApproveRequest(request.Id, request);

        return true;
    }
}