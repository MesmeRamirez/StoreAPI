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

    public interface IProductService
    {
        Task<ProductDto> Get(int id);
        Task<bool> PartialUpdate(int id, ProductDtoPartial model);
        Task<IEnumerable<ProductDto>> GetAll(ProductList list);
        Task<bool> Create(ProductCreateDto model);
        Task<bool> Remove(int id);
    }

    public class ProductService : IProductService
    {
        private readonly AppDB _context;

        public ProductService(AppDB context)
        {
            _context = context;
        }

        public async Task<ProductDto> Get(int id)
        {
            var result = new ProductDto();

            try
            {
                var product = await _context.Product.SingleAsync(x => x.Id == id);
                result = Mapper.Map<ProductDto>(product);
            } catch (Exception e)
            {

            }           

            return result;
        }

        public async Task<bool> PartialUpdate(int id, ProductDtoPartial model)
        {
            var result = false;

            try
            {
                var product = await _context.Product.SingleAsync(x => x.Id == id);
                
                if(model.ProductName != null)
                {
                    product.ProductName = model.ProductName;
                }
                if (model.Quantity != null)
                {
                    if (product.Quantity != model.Quantity)
                    {
                        _context.LogPriceProduct.Add(new CLogPriceProduct
                        {
                            ProductId = id,
                            UpdateDate = DateTime.Now,
                            OldPrice = product.Quantity,
                            NewPrice = model.Quantity
                        });

                        await _context.SaveChangesAsync();
                    }
                    product.Quantity = model.Quantity;
                }
                if (model.Price != null)
                {
                    product.Price = model.Price;
                }

                _context.Update(product);
                await _context.SaveChangesAsync();

                result = true;
            }
            catch (Exception e)
            {

            }

            return result;
        }

        //public async Task<IEnumerable<ProductDto>> GetAll(ProductList list)
        //{
        //    var result = new List<ProductDto>();

        //    try
        //    {
        //        var _filter = new ProductListFilter();

        //        if (!string.IsNullOrEmpty(list.Filter))
        //        {
        //            _filter = JsonConvert.DeserializeObject<ProductListFilter>(list.Filter);

        //            var query = (
        //            from p in _context.Product
        //            where _filter.ProductName.Equals(p.ProductName)
        //            select new ProductDto
        //            {
        //                ProductName = p.ProductName,
        //                Quantity = p.Quantity,
        //                Price = p.Price
        //            }
        //            ).Take(list.Take);
        //            result = await query.ToListAsync();
        //        }
        //        else
        //        {
        //            var query = (
        //            from p in _context.Product
        //            select new ProductDto
        //            {
        //                ProductName = p.ProductName,
        //                Quantity = p.Quantity,
        //                Price = p.Price
        //            }
        //            ).Take(10);
        //            result = await query.ToListAsync();
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //    }

        //    return result;
        //}

        public async Task<IEnumerable<ProductDto>> GetAll(ProductList list)
        {
            var result = new List<ProductDto>();

            try
            {
                var query = (
                from p in _context.Product
                select new ProductDto
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    UserId = p.UserId,
                    UrlImage = p.UrlImage
                });
                result = await query.ToListAsync();
            }
            catch (Exception e)
            {

            }

            return result;
        }

        public async Task<bool> Create(ProductCreateDto model)
        {
            var result = false;

            try
            {
                _context.Product.Add(new CProduct
                {
                    ProductName = model.ProductName,
                    Quantity = model.Quantity,
                    Price = model.Price,
                    UserId = model.UserId
                });

                await _context.SaveChangesAsync();
                
                result = true;
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
                //var product = await _context.Product.SingleOrDefaultAsync(x => x.Id == id);

                var product = await _context.Product.SingleOrDefaultAsync(x => x.Id == id);

                if (product != null)
                {
                    product.Deleted = true;
                    _context.Update(product);

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
