////using Microsoft.EntityFrameworkCore;

////using AlbumApp.Entities;

////var builder = WebApplication.CreateBuilder(args);

////// Add services to the container.
////builder.Services.AddControllersWithViews();

////// Add DB context service:
////string connStr = builder.Configuration.GetConnectionString("MidtermDB");
////builder.Services.AddDbContext<AlbumsDbContext>(options => options.UseSqlServer(connStr));


////var app = builder.Build();

////using (var scope = app.Services.CreateScope())
////{
////    var dbContext = scope.ServiceProvider.GetRequiredService<AlbumsDbContext>();
////    dbContext.Database.Migrate();
////}

////// Configure the HTTP request pipeline.
////if (!app.Environment.IsDevelopment())
////{
////    app.UseExceptionHandler("/Home/Error");
////    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
////    app.UseHsts();
////}

////app.UseHttpsRedirection();
////app.UseStaticFiles();

////app.UseRouting();

////app.UseAuthorization();

////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Home}/{action=Index}/{id?}");

////app.Run();



////using Microsoft.EntityFrameworkCore;
////using AlbumApp.Entities;

////var builder = WebApplication.CreateBuilder(args);

////// Add services to the container.
////builder.Services.AddControllersWithViews();

////// Add DB context service:
////string? connStr = builder.Configuration.GetConnectionString("MidtermDB");
////if (string.IsNullOrEmpty(connStr))
////{
////    throw new InvalidOperationException("Database connection string 'MidtermDB' is missing, check appsettings.json.");
////}

////builder.Services.AddDbContext<AlbumsDbContext>(options => options.UseSqlServer(connStr));

////var app = builder.Build();

////using (var scope = app.Services.CreateScope())
////{
////    var dbContext = scope.ServiceProvider.GetRequiredService<AlbumsDbContext>();
////    dbContext.Database.Migrate();
////}

////// Configure the HTTP request pipeline.
////if (!app.Environment.IsDevelopment())
////{
////    app.UseExceptionHandler("/Home/Error");
////    app.UseHsts();
////}

////app.UseHttpsRedirection();
////app.UseStaticFiles();
////app.UseRouting();
////app.UseAuthorization();

////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Home}/{action=Index}/{id?}");

////app.Run();



//using Microsoft.EntityFrameworkCore;
//using AlbumApp.Entities;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//// Add DB context service:
//string? connStr = builder.Configuration.GetConnectionString("MidtermDB");
//if (string.IsNullOrEmpty(connStr))
//{
//    throw new InvalidOperationException("Database connection string 'MidtermDB' is missing in appsettings.json.");
//}

//builder.Services.AddDbContext<AlbumsDbContext>(options => options.UseSqlServer(connStr));

//var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<AlbumsDbContext>();
//    dbContext.Database.Migrate();
//}

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseAuthorization();

////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Album}/{action=List}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "album",
//    pattern: "Album/{action}/{id?}",
//    defaults: new { controller = "Album" });

////app.MapControllerRoute(
////    name: "default",
////    pattern: "{controller=Home}/{action=Index}/{id?}");





//app.Run();

using Microsoft.EntityFrameworkCore;
using AlbumApp.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DB context service:
string? connStr = builder.Configuration.GetConnectionString("MidtermDB");
if (string.IsNullOrEmpty(connStr))
{
    throw new InvalidOperationException("Database connection string 'MidtermDB' is missing in appsettings.json.");
}

builder.Services.AddDbContext<AlbumsDbContext>(options => options.UseSqlServer(connStr));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AlbumsDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default route: Home Page
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Ensure Album routes work
app.MapControllerRoute(
    name: "album",
    pattern: "Album/{action}/{id?}",
    defaults: new { controller = "Album" });

app.Run();
