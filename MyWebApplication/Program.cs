using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

var cultureInfo = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

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

//Check
app.MapControllerRoute(
    name: "agecheck",
    pattern: "checkage",
    defaults: new { controller = "Check", action = "CheckAge" });

app.MapControllerRoute(
    name: "getsession",
    pattern: "sessionget",
    defaults: new { controller = "Check", action = "GetSession" });

app.MapControllerRoute(
    name: "setsession",
    pattern: "sessionset",
    defaults: new { controller = "Check", action = "SetSession" });

//External
app.MapControllerRoute(
    name: "project",
    pattern: "projects",
    defaults: new { controller = "External", action = "Projects" });

//Internal
app.MapControllerRoute(
    name: "about",
    pattern: "iabout",
    defaults: new { controller = "Internal", action = "About" });

app.MapControllerRoute(
    name: "contact",
    pattern: "icontact",
    defaults: new { controller = "Internal", action = "Contact" });

app.MapControllerRoute(
    name: "doctor",
    pattern: "fevercheck",
    defaults: new { controller = "Doctor", action = "FeverCheck" });


app.Run();
