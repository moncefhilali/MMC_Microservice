using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Partner.Commands;

public class PartnerCreateCmdHandler : IRequestHandler<PartnerCreateCmd, PartnerGetDTO>
{
    private readonly IUnitOfService _service;
    public PartnerCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<PartnerGetDTO> Handle(PartnerCreateCmd request, CancellationToken cancellationToken)
    {
        var partnerPostDTO = new PartnerPostDTO(request.Name, request.Description, request.LogoPath);
        var partner = await _service.PartnerService.CreateAsync(partnerPostDTO);
        return partner;
    }
}