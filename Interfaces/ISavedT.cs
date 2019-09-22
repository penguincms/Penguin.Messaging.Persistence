using Penguin.Messaging.Abstractions.Interfaces;
using Penguin.Messaging.Abstractions.Messages;

namespace Penguin.Messaging.Persistence.Interfaces
{
    /// <summary>
    /// A post-save message.
    /// </summary>
    /// <typeparam name="T">The type of the object being saved</typeparam>
    public interface ISaved<out T> : IMessage<T>
    {

    }
}