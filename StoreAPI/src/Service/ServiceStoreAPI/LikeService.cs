using Microsoft.EntityFrameworkCore;
using ModelStoreAPI.Dto;
using PersistenceStoreAPI;
using System;
using System.Threading.Tasks;
using ModelStoreAPI;
using Microsoft.AspNetCore.Hosting;

namespace ServiceStoreAPI
{
    public interface ILikeService
    {
        Task<bool> Create(LikeCreateDto model);
        Task<bool> Remove(int id);
    }

    public class LikeService : ILikeService
    {
        private readonly AppDB _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public LikeService(AppDB context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<bool> Create(LikeCreateDto model)
        {
            var result = false;

            try
            {
                var exists = await _context.LikeProduct.AnyAsync(x => x.UserId == model.UserId && x.ProductId == model.ProductId);

                if (!exists)
                {
                    _context.LikeProduct.Add(new CLikeByProduct
                    {
                        UserId = model.UserId,
                        ProductId = model.ProductId
                    });

                    await _context.SaveChangesAsync();
                }
                
            }
            catch (Exception e)
            {

            }

            return result;
        }

        public async Task<bool> Remove(int id)
        {
            var result = false;

            try
            {
                var like = await _context.LikeProduct.SingleOrDefaultAsync(x => x.Id == id);

                if (like != null)
                {
                    like.Deleted = true;
                    _context.Update(like);

                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                // Error logging
            }

            return result;
        }
    }
}
