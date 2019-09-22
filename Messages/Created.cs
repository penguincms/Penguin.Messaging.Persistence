using Penguin.Messaging.Persistence.Interfaces;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A post-save create message. Inherits from saved
    /// </summary>
    /// <typeparam name="T">The type of the object being created</typeparam>
    public class Created<T> : Saved<T>, ICreated<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Created(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}