using ApiMinimaLogin.Models;

namespace ApiMinimaLogin.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
