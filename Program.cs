using AutoMapperMvc.interfaces;
using AutoMapperMvc.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICategoryService, CategoryService>();
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
