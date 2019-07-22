using AutoMapper;
using ModelStoreAPI;
using ModelStoreAPI.Dto;

namespace StoreAPI.Config
{
    public class StoreAPIMapps
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CProduct, ProductDto>();
                cfg.CreateMap<ProductDto, CProduct>();
                cfg.CreateMap<CUser, UserDto>();
                cfg.CreateMap<UserDto, CUser>();
            });
        }
    }
}
