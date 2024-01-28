using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.City.Commands;

public record CityCreateCmd(string Name) : IRequest<CityGetDTO>;