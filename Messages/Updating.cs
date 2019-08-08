namespace Penguin.Messaging.Persistence.Messages
{
    /// <summary>
    /// A pre-save update message. Inherits from Saving
    /// </summary>
    /// <typeparam name="T">The type of the object being updated</typeparam>
    public class Updating<T> : Saving<T>
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of the message with the object being referenced attached
        /// </summary>
        /// <param name="target">The object being referenced</param>
        public Updating(T target) : base(target)
        {
        }

        #endregion Constructors
    }
}