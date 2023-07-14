using BookStore.Data;
using BookStore.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

#if DEBUG
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

var connectionString = builder.Configuration.GetConnectionString("BookStoreDB");
builder.Services.AddDbContext<BookStoresDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<BookStoresDbContext, BookStoresDbContext>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();


app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();
//app.MapControllerRoute(
//    name: "Default",
//    pattern: "bookApp/{controller=Home}/{action=Index}/{Id?}");

app.Run();
