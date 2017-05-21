using System.Threading.Tasks;

namespace ContactHub.BusinessLayer.IBusiness
{
    public interface IBusinessUser<T>
        where T : class
    {
        Task CreateNewUser(T obj);
        Task UpdateUser(T obj);
        Task DeleteUser(T obj);
        Task<T> GetUser(string username,string password);
        Task<T> GetUserById(string userId);
        Task<T> GetUserByEmailAddress(string emailAddress);
        Task<T> GetUserByUsername(string username);
    }
}
