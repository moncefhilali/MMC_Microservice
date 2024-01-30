using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Event.Commands;

public class EventCreateCmdHandler : IRequestHandler<EventCreateCmd, EventGetDTO>
{
    private readonly IUnitOfService _service;
    public EventCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<EventGetDTO> Handle(EventCreateCmd request, CancellationToken cancellationToken)
    {
        var eventPostDTO = new EventPostDTO
        (
            request.Title,
            request.Address,
            request.Description,
            request.ImagePath,
            request.StartDate,
            request.EndDate,
            request.CityId,
            request.ThemeId
        );

        var @event = await _service.EventService.CreateAsync(eventPostDTO);
        return @event;
    }
}