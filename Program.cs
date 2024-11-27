using Microsoft.EntityFrameworkCore;
using StoreApp.Models;
using SQLitePCL; 

var builder = WebApplication.CreateBuilder(args);


Batteries.Init();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
// app.MapGet("/", () => "Hello World!");
// app.MapGet("/btk", () => "BTK Akademi!");

app.Run();
