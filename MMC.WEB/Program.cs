using MMC.WEB.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddHttpClient<CityService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiSettings:BaseUrl"));
});
builder.Services.AddScoped<CityService>();

builder.Services.AddHttpClient<ThemeService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiSettings:BaseUrl"));
});
builder.Services.AddScoped<ThemeService>();

builder.Services.AddHttpClient<EventService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiSettings:BaseUrl"));
});
builder.Services.AddScoped<EventService>();

builder.Services.AddHttpClient<SpeakerService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiSettings:BaseUrl"));
});
builder.Services.AddScoped<SpeakerService>();




builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
