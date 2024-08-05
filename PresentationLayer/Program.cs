using BusinessLayer.Interface;
using BusinessLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Servisleri ekleyin
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

// IUserService'i DI konteynerine ekleyin
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Middleware ve endpoint'leri yapýlandýrýn
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
