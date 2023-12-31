using Microsoft.EntityFrameworkCore;
using Pierwszy__prodzekt;
using Pierwszy__prodzekt.Services;
using Pierwszy__prodzekt.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IWarehouseService, WarehouseService>();
builder.Services.AddDbContext<DbTestContext>(builder =>
{
    builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbTest;Integrated Security=True");
});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
