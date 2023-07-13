var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

#if DEBUG
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif



var app = builder.Build();


app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
//app.MapControllerRoute(
//    name: "Default",
//    pattern: "bookApp/{controller=Home}/{action=Index}/{Id?}");

app.Run();
