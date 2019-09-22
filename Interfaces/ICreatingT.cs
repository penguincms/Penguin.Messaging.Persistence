namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A pre-save create message. Inherits from Saving
    /// </summary>
    /// <typeparam name="T">The type of the object being created</typeparam>
    public interface ICreating<out T> : ISaving<T>
    {

    }
}