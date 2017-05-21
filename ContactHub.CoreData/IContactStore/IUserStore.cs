using System.Threading.Tasks;

namespace ContactHub.CoreData.IContactStore
{
    public interface IUserStore<T>
        where T : class
    {
        Task Create(T obj);
        Task Update(T obj);
        Task Delete(T obj);
        Task<T> FindUser(string username, string password);
        Task<T> FindUserByEmail(string emailAddress);
        Task<T> FindUserByUsername(string username);
        Task<T> FindUserById(string userId);
    }
}
