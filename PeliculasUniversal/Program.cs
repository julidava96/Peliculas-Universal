using PeliculasUniversal.Repository;
using PeliculasUniversal.Services;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Add(new ServiceDescriptor(typeof(SqlConnection), p =>
 {
     string conection = "Server=.\\sqlexpress;Database=Universal; Trusted_Connection=True; "; // para obtener conexion con la base de datos SQL
     var sqlConnection = new SqlConnection(conection);
     return sqlConnection;
 }, ServiceLifetime.Scoped));

builder.Services.AddScoped<PeliculaRepository>();
builder.Services.AddScoped<PeliculasService>();
builder.Services.AddScoped<GeneroRepository>();
builder.Services.AddScoped<GeneroService>();
// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
