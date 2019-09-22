namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A pre-save delete message. Inherits from Saving
    /// </summary>
    /// <typeparam name="T">The type of the object being deleted</typeparam>
    public interface IDeleting<out T> : ISaving<T>
    {

    }
}