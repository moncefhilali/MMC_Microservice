using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Partner.Commands;

public class PartnerUpdateCmdHandler : IRequestHandler<PartnerUpdateCmd, PartnerGetDTO>
{
    private readonly IUnitOfService _service;
    public PartnerUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<PartnerGetDTO> Handle(PartnerUpdateCmd request, CancellationToken cancellationToken)
    {
        var partnerPutDTO = new PartnerPutDTO(request.Id, request.Name, request.Description, request.LogoPath);
        var partner = await _service.PartnerService.UpdateAsync(partnerPutDTO);
        return partner;
    }
}