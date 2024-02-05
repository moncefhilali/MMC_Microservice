using MMC.WEB.Entities;

namespace MMC.WEB.Services;

public class SpeakerService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;
    private string _controller = "Speaker";

    public SpeakerService(HttpClient http, IConfiguration configuration)
    {
        _http = http;
        _baseUrl = configuration.GetValue<string>("ApiSettings:BaseUrl");
    }

    public async Task<Speaker> Find(Guid id)
    {
        var response = await _http.GetFromJsonAsync<Speaker>($"{_baseUrl}api/{_controller}/{id}");
        return response;
    }

    public async Task<IEnumerable<Speaker>> FindAll()
    {
        var response = await _http.GetFromJsonAsync<IEnumerable<Speaker>>($"{_baseUrl}api/{_controller}");
        return response;
    }

    public async Task<Speaker> Create(Speaker speaker)
    {
        var response = await _http.PostAsJsonAsync($"{_baseUrl}api/{_controller}", speaker);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Speaker>();
    }

    public async Task<Speaker> Update(Guid id, Speaker speaker)
    {
        var response = await _http.PutAsJsonAsync($"{_baseUrl}api/{_controller}/{id}", speaker);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Speaker>();
    }

    public async Task Delete(Guid id)
    {
        var response = await _http.DeleteAsync($"{_baseUrl}api/{_controller}/{id}");
        response.EnsureSuccessStatusCode();
    }
}