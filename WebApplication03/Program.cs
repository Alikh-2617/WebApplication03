using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;
using Microsoft.AspNetCore.Identity;
using WebApplication03.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//-------------------------------------------------

builder.Services.AddMvc();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection"));
});

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// connection till View UI 
builder.Services.AddCors(
    x => x.AddPolicy("corsPolicy", builder => 
    { builder.WithOrigins("*").
        AllowAnyMethod().
        AllowAnyHeader(); 
    }));

//----------------------------------------------


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//---------------------------------------------------

app.UseSession();

//---------------------------------------------------
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//---------------------------efter routing
app.UseCors("corsPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();    
//---------------------------
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
