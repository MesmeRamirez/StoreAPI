using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ModelStoreAPI.Dto;
using PersistenceStoreAPI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using ModelStoreAPI;

namespace ServiceStoreAPI
{
    public interface IBuyService
    {
        Task<bool> Create(UserPerProductCreateDto model);
        Task<IEnumerable<UserPerProductListDto>> GetAll(String id);
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

        public async Task<IEnumerable<UserPerProductListDto>> GetAll(string id)
        {
            var result = new List<UserPerProductListDto>();

            try
            {
                var query = (
                            from p in _context.UserPerProduct
                            from pr in _context.Product.Where(x => x.Id == p.ProductId)
                            from u in _context.Users.Where(x => x.Id == p.UserId)
                            where p.UserId.Equals(id)
                            select new UserPerProductListDto
                            {
                                UserId = p.UserId,
                                ProductId = p.ProductId,
                                ProductName = pr.ProductName,
                                Quantity = p.Quantity,
                                Price = pr.Price
                            }
                            );
                result = await query.ToListAsync();
            }
            catch (Exception e)
            {

            }

            return result;
        }
    }
}
