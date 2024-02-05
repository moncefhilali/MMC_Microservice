using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Speakers;

public class CreateModel : PageModel
{
    private readonly SpeakerService _service;
    private readonly IWebHostEnvironment _env;
    public CreateModel(SpeakerService service, IWebHostEnvironment env)
    {
        _service = service;
        _env = env;
    }




    [BindProperty]
    public Speaker Speaker { get; set; }




    public async Task OnGet()
    {

    }




    public async Task<IActionResult> OnPostCreate()
    {
        Speaker.PicturePath = await InsertImagesAsync();
        Speaker.MVP = false;
        Speaker.MCT = false;
        Speaker.Gender = 'M';
        Speaker.UserId = new Guid("3e89166a-4aae-42c5-9c2e-bb2d48c0a348");

        await _service.Create(Speaker);
        return RedirectToPage("/Speakers/Index");
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
