using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
	public class CoffeeShopService : ICoffeeShopService
	{
        private readonly ApplicationDbContext dbContext;

        public CoffeeShopService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<CoffeeShopModel>> List()
        {
            var coffeeShops = await (from shop in dbContext.CoffeeShops
                                     select new CoffeeShopModel()
                                     {
                                         Id = shop.Id,
                                         Name = shop.Name,
                                         OpeningHours = shop.OpeningHours,
                                         Address = shop.Address
                                     }).ToListAsync();

            return coffeeShops;
        }
    }
}
