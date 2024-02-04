using MMC.WEB.Entities;

namespace MMC.WEB.Services;

public class ThemeService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;
    private string _controller = "Theme";

    public ThemeService(HttpClient http, IConfiguration configuration)
    {
        _http = http;
        _baseUrl = configuration.GetValue<string>("ApiSettings:BaseUrl");
    }

    public async Task<Theme> Find(int id)
    {
        var response = await _http.GetFromJsonAsync<Theme>($"{_baseUrl}api/{_controller}/{id}");
        return response;
    }

    public async Task<IEnumerable<Theme>> FindAll()
    {
        var response = await _http.GetFromJsonAsync<IEnumerable<Theme>>($"{_baseUrl}api/{_controller}");
        return response;
    }

    public async Task<Theme> Create(Theme city)
    {
        var response = await _http.PostAsJsonAsync($"{_baseUrl}api/{_controller}", city);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Theme>();
    }

    public async Task<Theme> Update(int id, Theme city)
    {
        var response = await _http.PutAsJsonAsync($"{_baseUrl}api/{_controller}/{id}", city);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Theme>();
    }

    public async Task Delete(int id)
    {
        var response = await _http.DeleteAsync($"{_baseUrl}api/{_controller}/{id}");
        response.EnsureSuccessStatusCode();
    }
}