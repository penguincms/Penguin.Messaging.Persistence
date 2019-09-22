namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A post-save create message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being created</typeparam>
    public interface ICreated<out T> : ISaved<T>
    {

    }
}