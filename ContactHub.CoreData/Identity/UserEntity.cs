using System.ComponentModel.DataAnnotations;

namespace ContactHub.CoreData.Identity
{
    public class UserEntity<TKey>:IUser<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
