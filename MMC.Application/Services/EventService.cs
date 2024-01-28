using AutoMapper;
using MMC.Application.Interfaces;
using MMC.Application.IRepositories;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Services;

public class EventService : IEventService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public EventService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }




    public async Task<EventGetDTO> FindAsync(Guid id)
    {
        var @event = await _uow.EventRepository.GetAsync(id, e => e.City, e => e.Theme);

        if (@event is null) return null;

        return _map.Map<EventGetDTO>(@event);
    }
    public async Task<IEnumerable<EventGetDTO>> FindAllAsync()
    {
        var events = await _uow.EventRepository.GetAllAsync(e => e.City, equals => equals.Theme);

        if (events is null) return null;

        return _map.Map<IEnumerable<EventGetDTO>>(events);
    }
    public async Task<EventGetDTO> CreateAsync(EventPostDTO eventPostDTO)
    {
        var @event = _map.Map<Event>(eventPostDTO);
        if (!await _uow.EventRepository.PostAsync(@event))
            return null;

        await _uow.CompleteAsync();
        var createdEvent = await FindAsync(@event.Id);
        return createdEvent;
    }
    public async Task<EventGetDTO> UpdateAsync(EventPutDTO eventPutDTO)
    {
        var @event = _map.Map<Event>(eventPutDTO);
        var updatedEvent = await _uow.EventRepository.PutAsync(@event.Id, @event);

        await _uow.CompleteAsync();
        return _map.Map<EventGetDTO>(updatedEvent);
    }
    public async Task<bool> DeleteAsync(Guid id)
    {
        var success = await _uow.EventRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}