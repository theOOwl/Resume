using Application.Service.Implement;
using Application.Service.Interface;
using Domain.RepositoryInterface;
using Infrastructure.Repository;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;
using Resume.Presenation.Models.ResumeDbContext;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
#region Repositories
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
builder.Services.AddScoped<IMySkillsRepsitory, MySkillsRepository>();
builder.Services.AddDbContext<ResumeDbContext>();
builder.Services.AddScoped<IContactMeRepository, ContactMeRepository>();
#endregion

#region Services
builder.Services.AddScoped<IContactMeService, ContactMeService>();
builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<IEducationService, EducationService>();
builder.Services.AddScoped<IExperienceService, ExperienceService>();
builder.Services.AddScoped<IMySkillsService, MySkillsService>();
#endregion
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
            name: "area",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
