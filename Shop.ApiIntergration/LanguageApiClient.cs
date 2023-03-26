using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Shop.ApiIntergration;
using Shop_ViewModels.Common;
using Shop_ViewModels.System.Languages;

namespace Shop.ApiIntergration
{
    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
    {
        public LanguageApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageVm>>>("/api/languages");
        }
    }
}
