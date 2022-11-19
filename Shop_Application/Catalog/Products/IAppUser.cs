using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_ViewModels.Catalog.Products;

namespace Shop_Application.Catalog.Products
{
    public interface IAppUser
    {
        Task<List<AppUserViewModel>> GetAll();
    }
}
