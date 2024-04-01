using Kmakai.WardrobeInventory.Client.Pages;
using Kmakai.WardrobeInventory.Components;
using Microsoft.EntityFrameworkCore;
using Kmakai.WardrobeInventory.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddDbContext<WardrobeContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("WardrobeContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Kmakai.WardrobeInventory.Client._Imports).Assembly);

app.Run();
