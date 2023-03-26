using Shop_ViewModels.Catalog.Categories;

namespace Shop.ApiIntergration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
        Task<CategoryVm> GetById(string languageId, int id);
    }
}
