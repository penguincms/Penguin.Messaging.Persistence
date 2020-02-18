namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A pre-save update message. Inherits from Saving
    /// </summary>
    /// <typeparam name="T">The type of the object being updated</typeparam>
    public interface IUpdating<out T> : ISaving<T>, IUpdated
    {
    }
}