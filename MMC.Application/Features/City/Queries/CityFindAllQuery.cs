using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.City.Queries;

public record CityFindAllQuery : IRequest<IEnumerable<CityGetDTO>>;