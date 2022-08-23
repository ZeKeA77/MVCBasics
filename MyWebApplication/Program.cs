var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
});

var app = builder.Build();

app.UseSession();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );


//Route for the individual pages
app.MapControllerRoute(
    name: "project",
    pattern: "projects",
    defaults: new { controller = "Home", action = "Projects" });

app.MapControllerRoute(
    name: "about",
    pattern: "iabout",
    defaults: new { controller = "Home", action = "About" });

app.MapControllerRoute(
    name: "contact",
    pattern: "icontact",
    defaults: new { controller = "Home", action = "Contact" });


app.Run();
