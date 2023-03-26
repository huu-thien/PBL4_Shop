using Shop_ViewModels.Common;
using Shop_ViewModels.System.Languages;

namespace Shop.ApiIntergration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
