namespace MMC.Application.Interfaces;

public interface IUnitOfService
{
    ICityService CityService { get; }
    IEventService EventService { get; }
    IModeService ModeService { get; }
    IPartnerService PartnerService { get; }
    IThemeService ThemeService { get; }
}