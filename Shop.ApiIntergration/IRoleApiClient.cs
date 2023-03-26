using Shop_ViewModels.Common;
using Shop_ViewModels.System.Roles;

namespace Shop.ApiIntergration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}
