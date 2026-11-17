using University_Explorer_Portal.Components;
using University_Explorer_Portal.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//  Countries API
builder.Services.AddHttpClient<CountryService>(client =>
{
    client.BaseAddress = new Uri("https://countries.dev");
});
// Universities API
builder.Services.AddHttpClient<UniversityService>(client =>
{
    client.BaseAddress = new Uri("http://universities.hipolabs.com");
});
// Students Application API
builder.Services.AddHttpClient<StudentApplicationService>(client =>
{
    client.BaseAddress = new Uri("https://edutots.net");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();