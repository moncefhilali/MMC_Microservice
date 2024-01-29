namespace MMC.Application.Interfaces;

public interface IUnitOfService
{
    ICityService CityService { get; }
    IEventService EventService { get; }
    IModeService ModeService { get; }
    IPartnerService PartnerService { get; }
    ISponsorService SponsorService { get; }
    IThemeService ThemeService { get; }
}