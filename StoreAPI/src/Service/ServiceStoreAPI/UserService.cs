using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ModelStoreAPI.Dto;
using PersistenceStoreAPI;
using System;
using System.Threading.Tasks;

namespace ServiceStoreAPI
{

    public interface IUserService
    {
        Task<UserDto> Get(string id);
    }

    public class UserService : IUserService
    {
        private readonly AppDB _context;

        public UserService(AppDB context)
        {
            _context = context;
        }

        public async Task<UserDto> Get(string id)
        {
            var result = new UserDto();

            try
            {
                var user = await _context.Users.SingleAsync(x => x.Id == id);
                result = Mapper.Map<UserDto>(user);
            }
            catch (Exception e)
            {

            }

            return result;
        }
    }
}
