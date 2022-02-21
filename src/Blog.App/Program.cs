using AspNetCore.SassCompiler;
using Blog.App.Data.Global;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMasaBlazor(builder =>
{
    builder.UseTheme(option =>
        option.Primary = "#4318FF"
    );
});

// Ìí¼ÓSass Compiler
builder.Services.AddSassCompiler();

builder.Services.AddScoped<NavHelper>();

builder.Services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
