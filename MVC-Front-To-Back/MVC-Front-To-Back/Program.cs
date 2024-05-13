using Microsoft.EntityFrameworkCore;
using MVC_Front_To_Back.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDBContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("default")));

var app = builder.Build();

app.UseStaticFiles();//~ isaresi olmadan rootlari vermek

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
