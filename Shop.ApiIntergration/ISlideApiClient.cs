using Shop_ViewModels.Utilities.Slide;

namespace Shop.ApiIntergration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
