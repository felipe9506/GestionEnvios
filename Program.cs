using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GestionEnvios.Models.AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();
<<<<<<< HEAD
builder.Services.AddSession();
=======
>>>>>>> 52c012a4f7a60ed63a4c1e2f4a27768957515cc4

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
<<<<<<< HEAD
app.UseSession();
=======
>>>>>>> 52c012a4f7a60ed63a4c1e2f4a27768957515cc4

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
<<<<<<< HEAD
    pattern: "{controller=Auth}/{action=Login}/{id?}");
=======
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
>>>>>>> 52c012a4f7a60ed63a4c1e2f4a27768957515cc4


app.Run();
