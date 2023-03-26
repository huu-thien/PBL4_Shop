using Shop_ViewModels.Catalog.Categories;
using Shop_ViewModels.Catalog.Products;
using Shop_ViewModels.Common;

namespace Shop.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }
        public PagedResult<ProductVm> Products { get; set; }
    }
}
