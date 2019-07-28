using ModelStoreAPI.Dto;
using PersistenceStoreAPI;
using System;
using System.Threading.Tasks;
using ModelStoreAPI;
using Microsoft.AspNetCore.Hosting;

namespace ServiceStoreAPI
{
    public interface ILogPriceService
    {
        Task<bool> Create(LogPriceProductCreateDto model);
    }

    public class LogPriceService :  ILogPriceService
    {
        private readonly AppDB _context;

        public LogPriceService(AppDB context)
        {
            _context = context;
        }

        public async Task<bool> Create(LogPriceProductCreateDto model)
        {
            var result = false;

            try
            {
                _context.LogPriceProduct.Add(new CLogPriceProduct
                {
                    ProductId = model.ProductId,
                    UpdateDate = DateTime.Now,
                    OldPrice = model.OldPrice,
                    NewPrice = model.NewPrice
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
