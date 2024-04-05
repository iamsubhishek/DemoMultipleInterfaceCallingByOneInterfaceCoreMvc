using DemoInterfaceCalling.Interfaces.Interfaces;
using DemoInterfaces.DataAccess.Implementation;
using DemoInterfaces.EfCore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddDbContext<DemoContext>(options =>
options.UseSqlServer(
                    Configuration.GetConnectionString("subhiConn"))
            );

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IMaster, Master>();
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
