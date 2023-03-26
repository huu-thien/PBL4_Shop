using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop_Data.Entities;
using Shop_Data.Enums;

namespace Shop_Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of PBL4: Shop" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of PBL4: Shop" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of PBL4: Shop" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Máy tính xách tay", LanguageId = "vi", SeoAlias = "may-tinh-xach-tay", SeoDescription = "Sản phẩm máy tính xách tay", SeoTitle = "Sản phẩm máy tính xách tay" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Laptop", LanguageId = "en", SeoAlias = "lap-top", SeoDescription = "The laptop product", SeoTitle = "The laptop product" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Điện thoại di động", LanguageId = "vi", SeoAlias = "dien-thoai-di-dong", SeoDescription = "Sản phẩm điện thoại di động", SeoTitle = "Sản phẩm điện thoại di động" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Smart Phone", LanguageId = "en", SeoAlias = "smart-phone", SeoDescription = "The Smart Phone product", SeoTitle = "The Smart Phone product" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 15000000,
               Price = 20000000,
               Stock = 5,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6",
                     LanguageId = "vi",
                     SeoAlias = "lap-top-gaming-gigabyte-g5-51vn1235so",
                     SeoDescription = "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6",
                     SeoTitle = "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6",
                     Details = "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6",
                     Description = "Laptop Gaming GIGABYTE G5 GD-51VN123SO i5-11400H/16GB/512GB/RTX3050/15.6"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Samsung Galaxy A73 5G",
                        LanguageId = "en",
                        SeoAlias = "samsung-galaxy-a73-5g",
                        SeoDescription = "Samsung Galaxy A73 5G",
                        SeoTitle = "Samsung Galaxy A73 5G",
                        Details = "Samsung Galaxy A73 5G",
                        Description = "Samsung Galaxy A73 5G"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456@"),
                SecurityStamp = string.Empty,
                FirstName = "Thien",
                LastName = "Nguyen",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
              );
        }
    }
}
