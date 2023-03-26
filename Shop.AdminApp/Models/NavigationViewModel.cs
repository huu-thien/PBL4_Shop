using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_ViewModels.System.Languages;

namespace Shop.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<SelectListItem> Languages { get; set; }

        public string CurrentLanguageId { get; set; }

        public string ReturnUrl { set; get; }
    }
}
