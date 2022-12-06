using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;
using Microsoft.AspNetCore.Identity;
using WebApplication03.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//-------------------------------------------------

builder.Services.AddMvc();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection"));
});

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

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
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();    
//---------------------------
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
