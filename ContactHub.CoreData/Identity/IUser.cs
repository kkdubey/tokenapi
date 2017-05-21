namespace ContactHub.CoreData.Identity
{
    public interface IUser<out TKey>
    {
        TKey Id { get; }
    }
    interface IUser:IUser<string>
    {

    }
}
