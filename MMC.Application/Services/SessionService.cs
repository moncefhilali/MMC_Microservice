using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Services;

public class SessionService : ISessionService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public SessionService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<SessionGetDTO> FindAsync(Guid id)
    {
        var session = await _uow.SessionRepository.GetAsync(id, e => e.Mode, e => e.Event);

        if (session is null) return null;

        return _map.Map<SessionGetDTO>(session);
    }
    public async Task<IEnumerable<SessionGetDTO>> FindAllAsync()
    {
        var sessions = await _uow.SessionRepository.GetAllAsync(e => e.Mode, equals => equals.Event);

        if (sessions is null) return null;

        return _map.Map<IEnumerable<SessionGetDTO>>(sessions);
    }
    public async Task<SessionGetDTO> CreateAsync(SessionPostDTO sessionPostDTO)
    {
        var session = _map.Map<Session>(sessionPostDTO);
        if (!await _uow.SessionRepository.PostAsync(session))
            return null;

        await _uow.CompleteAsync();
        var createdSession = await FindAsync(session.Id);
        return createdSession;
    }
    public async Task<SessionGetDTO> UpdateAsync(SessionPutDTO sessionPutDTO)
    {
        var session = _map.Map<Session>(sessionPutDTO);
        var updatedSession = await _uow.SessionRepository.PutAsync(session.Id, session);

        await _uow.CompleteAsync();
        return _map.Map<SessionGetDTO>(updatedSession);
    }
    public async Task<bool> DeleteAsync(Guid id)
    {
        var success = await _uow.SessionRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}