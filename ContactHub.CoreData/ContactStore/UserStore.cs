using System;
using System.Data.Entity;
using System.Threading.Tasks;
using ContactHub.CoreData.IContactStore;
using ContactHub.CoreData.DB_ConnectionString;

namespace ContactHub.CoreData.ContactStore
{
    public class UserStore<T> : IUserStore<T>, IDisposable
        where T : class
    {
        protected ContactHubContextDB _ContextDB;
        private DbSet<T> DbSet;
        public UserStore()
        {
            var connectionString = DBConnectionString.ConnectionString;
            _ContextDB = new ContactHubContextDB();
            DbSet = _ContextDB.Set<T>();
        }
        Task IUserStore<T>.Create(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("object null");
            DbSet.Add(obj);
            var result = _ContextDB.SaveChangesAsync();
            return Task.FromResult(result);
        }
        Task IUserStore<T>.Delete(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("object null");
            _ContextDB.Entry<T>(obj).State = EntityState.Deleted;
            var result = _ContextDB.SaveChangesAsync();
            return Task.FromResult(result);
        }
        Task IUserStore<T>.Update(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("object null");
            _ContextDB.Entry<T>(obj).State = EntityState.Modified;
            var result = _ContextDB.SaveChangesAsync();
            return Task.FromResult(result);
        }
        Task<T> IUserStore<T>.FindUser(string username, string password)
        {
            var result = _ContextDB.User.FirstOrDefaultAsync(x => x.Username.Equals(username) && x.Password.Equals(password));
            return Task.FromResult(result as T);
        }
        Task<T> IUserStore<T>.FindUserByEmail(string emailAddress)
        {
            var result = _ContextDB.User.FirstOrDefaultAsync(x => x.EmailAddress.Equals(emailAddress));
            return Task.FromResult(result as T);
        }
        Task<T> IUserStore<T>.FindUserById(string userId)
        {
            var result = _ContextDB.User.FirstOrDefaultAsync(x => x.Id.Equals(userId));
            return Task.FromResult(result as T);
        }
        Task<T> IUserStore<T>.FindUserByUsername(string username)
        {
            var result = _ContextDB.User.FirstOrDefaultAsync(x => x.Username.Equals(username));
            return Task.FromResult(result as T);
        }

        #region Disposable Implement
        public void Dispose()
        {
            ((IDisposable)_ContextDB).Dispose();
        }
        #endregion
    }
}
