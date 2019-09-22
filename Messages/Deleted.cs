using Penguin.Messaging.Persistence.Interfaces;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A post-save delete message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being deleted</typeparam>
    public class Deleted<T> : Saved<T>, IDeleted<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Deleted(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}