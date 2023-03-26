using Shop_ViewModels.Catalog.Products;
using Shop_ViewModels.Common;

namespace Shop.ApiIntergration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
        Task<bool> CreateProduct(ProductCreateRequest request);
        Task<bool> UpdateProduct(ProductUpdateRequest request);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVm> GetById(int id, string languageId);
        Task<List<ProductVm>> GetLatestProducts(string languageId, int take);
        Task<bool> DeleteProduct(int id);
    }
}
