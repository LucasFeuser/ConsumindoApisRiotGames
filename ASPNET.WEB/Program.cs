using CLASSLIBRARY.BACK.Endpoint;
using CLASSLIBRARY.BACK.Interfaces;
using CLASSLIBRARY.BACK.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddScoped<IEndPointClient, EndPointClient>();
builder.Services.AddScoped<IEndPoint, Services>();

// Add services to the container.
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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=HomeController}/{action=BuscarDados}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
