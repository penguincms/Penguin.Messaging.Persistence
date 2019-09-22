using Penguin.Messaging.Abstractions.Messages;
using Penguin.Messaging.Persistence.Interfaces;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A post-save message.
    /// </summary>
    /// <typeparam name="T">The type of the object being saved</typeparam>
    public class Saved<T> : Message<T>, ISaved<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Saved(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}