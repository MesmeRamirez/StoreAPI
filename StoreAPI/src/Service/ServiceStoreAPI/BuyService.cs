using Microsoft.EntityFrameworkCore;
using ModelStoreAPI.Dto;
using PersistenceStoreAPI;
using System;
using System.Threading.Tasks;
using ModelStoreAPI;
using Microsoft.AspNetCore.Hosting;
namespace ServiceStoreAPI
{
    public interface IBuyService
    {
        Task<bool> Create(UserPerProductCreateDto model);
    }

    public class BuyService : IBuyService
    {
        private readonly AppDB _context;

        public BuyService(AppDB context)
        {
            _context = context;
        }

        public async Task<bool> Create(UserPerProductCreateDto model)
        {
            var result = false;

            try
            {
                var product = await _context.Product.SingleAsync(x => x.Id == model.ProductId);
                product.Quantity = product.Quantity - model.Quantity;
                _context.Update(product);
                await _context.SaveChangesAsync();

                _context.UserPerProduct.Add(new CUserPerProduct
                {
                    UserId = model.UserId,
                    ProductId = model.ProductId,
                    Quantity = model.Quantity,
                    UpdateDate = DateTime.Now
                });

                await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

            }

            return result;
        }
    }
}
