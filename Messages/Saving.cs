using Penguin.Messaging.Abstractions.Messages;
using Penguin.Messaging.Persistence.Interfaces;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A pre-save message.
    /// </summary>
    /// <typeparam name="T">The type of the object being saved</typeparam>
    public class Saving<T> : Message<T>, ISaving<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Saving(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}