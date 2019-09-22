namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A post-save delete message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being deleted</typeparam>
    public interface IDeleted<out T> : ISaved<T>
    {

    }
}