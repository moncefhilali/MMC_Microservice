using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Events;

public class CreateModel : PageModel
{
    private readonly EventService _service;
    private readonly IWebHostEnvironment _env;
    public CreateModel(EventService service, IWebHostEnvironment env)
    {
        _service = service;
        _env = env;
    }




    [BindProperty]
    public Event Event { get; set; }
    public IEnumerable<City> Cities { get; private set; }
    public IEnumerable<Theme> Themes { get; private set; }




    public async Task OnGet()
    {
        Cities = await _service.FindAllCities();
        Themes = await _service.FindAllThemes();
    }




    public async Task<IActionResult> OnPostCreate()
    {
        Event.ImagePath = await InsertImagesAsync();
        if (string.IsNullOrEmpty(Event.Title))
        {
            ModelState.AddModelError("Event.Title", "The field \"Title\" is required!");
            await OnGet();
            return Page();
        }

        await _service.Create(Event);
        return RedirectToPage("/Events/Index");
    }





    private async Task<string> InsertImagesAsync()
    {
        string path = string.Empty;
        try
        {
            var files = HttpContext.Request.Form.Files;

            if (files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file != null && file.Length > 0)
                    {
                        var fileName = $"{Guid.NewGuid()}_{file.FileName}";
                        var filePath = Path.Combine(_env.WebRootPath, "images", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                            await file.CopyToAsync(stream);
                        path = fileName;
                    }
                }
            }
            return path;
        }
        catch (Exception)
        {
            return null;
        }
    }
}