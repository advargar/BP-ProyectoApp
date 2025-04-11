using BP_Proyecto.Models;

namespace BP_Proyecto.Services
{
    public interface IUserService
    {
        Task<User> GetUser(string username, string password);
        Task<User> SaveUser(User user);

    }
}
