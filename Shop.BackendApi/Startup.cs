//using Microsoft.EntityFrameworkCore;
//using Shop_Application.Catalog.Products;
//using Shop_Data.Entity_Framework;
//using Shop_Utilities.Constants;

//namespace Shop.BackendApi
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }
//        public IConfiguration Configuration { get; }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddDbContext<EShopDbContext>(options =>
//                     options.UseSqlServer(Configuration.GetConnectionString("ShopDb")));

//            //Declare DI
//            services.AddTransient<IPublicProductService, PublicProductService>();
//            services.AddTransient<IAppUser, AppUserService>();

//            services.AddControllersWithViews();
//        }
//        public void Configure(WebApplication app, IWebHostEnvironment env)
//        {
//            if (!app.Environment.IsDevelopment())
//            {
//                app.UseExceptionHandler("/Home/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//            }

//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseAuthorization();

//            app.MapControllerRoute(
//                name: "default",
//                pattern: "{controller=Home}/{action=Index}/{id?}");

//            app.Run();
//        }
//    }
//}




