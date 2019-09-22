using Penguin.Messaging.Persistence.Interfaces;

namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A pre-save create message. Inherits from Saving
    /// </summary>
    /// <typeparam name="T">The type of the object being created</typeparam>
    public class Creating<T> : Saving<T>, ICreating<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Creating(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}