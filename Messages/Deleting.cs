using Penguin.Messaging.Persistence.Interfaces;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A pre-save delete message. Inherits from Saving
    /// </summary>
    /// <typeparam name="T">The type of the object being deleted</typeparam>
    public class Deleting<T> : Saving<T>, IDeleting<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Deleting(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}