
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Shop.BackendApi;
using Shop_Application.Catalog.Products;
using Shop_Data.Entity_Framework;

var builder = WebApplication.CreateBuilder(args);

//add services to the container.
builder.Services.AddDbContext<EShopDbContext>(options =>
                     options.UseSqlServer(builder.Configuration.GetConnectionString("ShopDb")));
builder.Services.AddMemoryCache();
builder.Services.AddTransient<IPublicProductService, PublicProductService>();
builder.Services.AddTransient<IAppUser, AppUserService>();
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Shop", Version = "v1" });
});

var app = builder.Build();
//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Shop Demo V1");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//cach 2 ko can startup
//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services); // calling ConfigureServices method

//var app = builder.Build();
//startup.Configure(app, builder.Environment); // calling Configure method