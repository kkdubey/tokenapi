using ContactHub.CoreData.ContactStore;
using ContactHub.CoreData.IContactStore;

namespace ContactHub.BusinessLayer.ContactHub_DAL
{
    class ContactHubManager<T>
        where T : class
    {
        public static IUserStore<T> UserManager;
        static ContactHubManager()
        {
            UserManager = new UserStore<T>();
        }
    }
}
