using Microsoft.AspNetCore.Mvc;
using Validator.Application.Interfaces;
using Validator.Domain.DTOs;

namespace Validator.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JoinEventController : ControllerBase
{
    private readonly IJoinEventService _service;
    public JoinEventController(IJoinEventService service) => _service = service;




    [HttpGet]
    public async Task<IActionResult> GetAllRequests()
    {
        var request = await _service.GetAllRequests();
        return Ok(request);
    }

    [HttpPost]
    public async Task<IActionResult> RequestJoinEvent(JoinEventPostDTO joinEventPostDTO)
    {
        var success = await _service.RequestJoinEvent(joinEventPostDTO);
        return Ok(success);
    }

    [HttpPut]
    public async Task<IActionResult> ApproveRequest(JoinEventPutDTO joinEventPutDTO)
    {
        var success = await _service.ApproveRequest(joinEventPutDTO);
        return Ok(success);
    }
}