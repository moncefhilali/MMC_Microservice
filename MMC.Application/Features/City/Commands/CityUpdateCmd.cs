using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.City.Commands;

public record CityUpdateCmd(int Id, string Name) : IRequest<CityGetDTO>;