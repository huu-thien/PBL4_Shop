using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Shop_ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Display(Name = "Giá bán")]
        public decimal Price { set; get; }
        [Display(Name = "Giá Nhập")]
        public decimal OriginalPrice { set; get; }

        [Display(Name = "Tồn kho")]
        public int Stock { set; get; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { set; get; }

        [Display(Name = "Mô tả sản phẩm")]
        public string Description { set; get; }
        [Display(Name = "Chi tiết sản phẩm")]
        public string? Details { set; get; }


        public string? SeoDescription { set; get; }
        public string? SeoTitle { set; get; }
        public string? SeoAlias { get; set; }
        public string? LanguageId { set; get; }
        public bool? IsFeatured { get; set; }

        [Display(Name = "Hình ảnh sản phẩm")]
        public IFormFile? ThumbnailImage { get; set; }
    }
}
