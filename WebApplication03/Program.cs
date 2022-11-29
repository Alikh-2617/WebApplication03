using Microsoft.EntityFrameworkCore;
using WebApplication03.Data;

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
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
