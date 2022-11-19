using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop_Data.Entity_Framework;
using Shop_ViewModels.Catalog.Products;

namespace Shop_Application.Catalog.Products
{
    public class AppUserService : IAppUser
    {
        private readonly EShopDbContext _context;
        public AppUserService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<AppUserViewModel>> GetAll()
        {
            var query = from p in _context.AppUsers                   
                        select new { p};

            var data = await query.Select(x => new AppUserViewModel()
            {
               FirstName = x.p.FirstName,
               LastName = x.p.LastName,
               Dob = x.p.Dob
            }).ToListAsync();
            return data;
        }
    }
    
}
