using Bussiness.Services.Abstracts;
using Bussiness.Services.Concretes;
using Core.RepositoryAbstracts;
using Data.DAL;
using Data.RepositoryConcretes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddScoped<IMovieRepository,MovieRepository>();
builder.Services.AddScoped<ISliderRepository,SliderRepository>();
builder.Services.AddScoped<IOfficeRepository,OfficeRepository>();
builder.Services.AddScoped<IContactMassageRepository,ContactMassageRepository>();
builder.Services.AddScoped<ICommentRepository,CommentRepository>();

builder.Services.AddScoped<IMovieService,MovieService>();
builder.Services.AddScoped<ISliderService,SliderService>();
builder.Services.AddScoped<IOfficeService,OfficeService>();
builder.Services.AddScoped<IContactMassageService,ContactMassageService>();
builder.Services.AddScoped<ICommentService,CommentService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
			name: "areas",
			pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}"
          );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
