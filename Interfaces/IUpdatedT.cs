namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A post-save update message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being udpated</typeparam>
    public interface IUpdated<out T> : ISaved<T>, IUpdated
    {
    }
}