using ApiMinimaLogin.Models;

namespace ApiMinimaLogin.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "samuel", EmailAddress = "samuel@email.com", Password = "samu", GivenName = "sa", Surname = "samu", Role = "Administrator" },
            new() { Username = "samuel2", EmailAddress = "samuel2@email.com", Password = "samu2", GivenName = "sa2", Surname = "samu2", Role = "Standard" },
        };
    }
}
