
using Microsoft.EntityFrameworkCore;
using CarDealership.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CarDealershipContextConnection") ?? throw new InvalidOperationException("Connection string 'CarDealershipContextConnection' not found.");

builder.Services.AddDbContext<CarDealershipContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CarDealershipUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CarDealershipContext>();



// Add services to the container.
builder.Services.AddControllersWithViews();


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

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
