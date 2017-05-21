using System;

namespace ContactHub.CoreData.Identity
{
    public class UserIdentity:UserEntity<string>
    {
        public UserIdentity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
