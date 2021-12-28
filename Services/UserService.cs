using BlazorApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class UserService : IUserService
    {
        private IHttpService _httpService;

        public UserService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _httpService.Get<IEnumerable<User>>("/users");
        }
        public async Task<IEnumerable<User>> GetAll2()
        {
            return await _httpService.Get<IEnumerable<User>>("/users");
        }
        public async Task<IEnumerable<User>> GetLogin(User user)
        {
            var result = await _httpService.GetLogin<User>("/users/authenticate", user);
            return (IEnumerable<User>)result;
            //
        }
    }
}