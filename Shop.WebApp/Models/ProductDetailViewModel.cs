using Shop_ViewModels.Catalog.Categories;
using Shop_ViewModels.Catalog.ProductImages;
using Shop_ViewModels.Catalog.Products;

namespace Shop.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm? Category { get; set; }

        public ProductVm? Product { get; set; }

        public List<ProductVm> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
