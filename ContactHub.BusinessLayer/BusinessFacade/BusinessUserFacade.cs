using Newtonsoft.Json;
using System.Threading.Tasks;
using ContactHub.BusinessLayer.IBusiness;
using ContactHub.BusinessLayer.ContactHub_DAL;
using ContactHub.CoreData.Entities.Annonymous;

namespace ContactHub.BusinessLayer.BusinessFacade
{
    public class BusinessUserFacade<T> : IBusinessUser<T>
        where T : class
    {
        Task IBusinessUser<T>.CreateNewUser(T obj)
        {
            var user = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(obj).ToString());
            var result = ContactHubManager<User>.UserManager.Create(user);
            return Task.FromResult(result);
        }

        Task IBusinessUser<T>.DeleteUser(T obj)
        {
            var result = ContactHubManager<T>.UserManager.Delete(obj);
            return Task.FromResult(result);
        }

        Task IBusinessUser<T>.UpdateUser(T obj)
        {
            var result = ContactHubManager<T>.UserManager.Update(obj);
            return Task.FromResult(result);
        }

        Task<T> IBusinessUser<T>.GetUser(string username, string password)
        {
            var result = ContactHubManager<T>.UserManager.FindUser(username, password);
            return Task.FromResult(result as T);
        }

        Task<T> IBusinessUser<T>.GetUserByEmailAddress(string emailAddress)
        {
            var result = ContactHubManager<T>.UserManager.FindUserByEmail(emailAddress);
            return Task.FromResult(result as T);
        }

        Task<T> IBusinessUser<T>.GetUserById(string userId)
        {
            var result = ContactHubManager<T>.UserManager.FindUserById(userId);
            return Task.FromResult(result as T);
        }

        Task<T> IBusinessUser<T>.GetUserByUsername(string username)
        {
            var result = ContactHubManager<T>.UserManager.FindUserByUsername(username);
            return Task.FromResult(result as T);
        }
    }
}
